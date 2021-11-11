using Dream14.Core.DomainServices;
using Dream14.ViewModels;
using Dream14.ViewModels.Global;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Dream14.WebAdmin.Controllers
{
    public class FrontEndController : Controller
    {
        /// <summary>
        /// IAuthService data member
        /// </summary>
        private readonly IAuthService _authService;

        /// <summary>
        /// IFrontEndService data member
        /// </summary>
        private readonly IFrontEndService _frontEndService;

        /// <summary>
        /// ILogger data member
        /// </summary>
        private readonly ILogger<FrontEndController> _logger;

        /// <summary>
        /// AccountController Constructor
        /// </summary>
        /// <param name="authService">IAuthService object reference</param>
        public FrontEndController(IAuthService authService, IFrontEndService frontEndService, ILogger<FrontEndController> logger)
        {
            _authService = authService;
            _frontEndService = frontEndService;
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FrontEndEventDetail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([Bind] AuthUser user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _authService.UserAuthenticate(user);

                    if (result.IsSuccess == true && result.RoleName == "FrontEnd")
                    {
                        // Remove commma from Roles
                        //result.RoleName = result.RoleName.Substring(1);
                        result.RoleName = result.RoleName;

                        string role = result.RoleName.Trim();
                        var claims = new List<Claim>
                        {
                            new Claim("FEUserID", Convert.ToString(result.UserId)),
                            new Claim("FEUserName", user.UserName),
                            new Claim("FEFullName", result.FullName),
                            new Claim("FEBalance", result.Balance),
                            new Claim("UserType", result.UserType)
                        };

                        // Add Roles
                        role.Split(",").ToList().ForEach(r =>
                        {
                            claims.Add(new Claim(ClaimTypes.Role, r));
                        });

                        ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "Felogin");
                        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                        HttpContext.SignInAsync("Dream14Cookies", principal, new AuthenticationProperties
                        {
                            ExpiresUtc = DateTime.UtcNow.AddHours(12),
                            IsPersistent = false,
                            AllowRefresh = false
                        });

                        return RedirectToAction("Index", "FrontEnd");
                    }
                    else
                    {
                        result.Message = "Invalid Credentials.Please try with different one.";
                        TempData["UserLoginFailed"] = result.Message;
                        return View();
                    }
                }
                else
                    return View();
            }

            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                return View("/Error");
            }
        }

        /// <summary>
        /// Logout from system
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "FrontEnd");
        }

        [HttpPost]
        public JsonResult CheckOldPassword(string oldPassword)
        {
            IEnumerable<Claim> claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "FEUserID").FirstOrDefault().Value);
            BaseResult result = _frontEndService.CheckOldPassword(oldPassword, userId);
            return Json(result);
        }


        [HttpPost]
        public JsonResult ChangePassword(string NewPassword)
        {
            IEnumerable<Claim> claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "FEUserID").FirstOrDefault().Value);
            BaseResult result = _frontEndService.ChangePassword(NewPassword, userId);
            return Json(result);
        }

        [HttpPost]
        public JsonResult GetUserBetButtonValue()
        {
            IEnumerable<Claim> claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "FEUserID").FirstOrDefault().Value);
            Dictionary<string, string> keyValuePairs = _frontEndService.GetUserBetButtonValue(userId);
            return Json(keyValuePairs);
        }

        [HttpPost]
        public JsonResult UpdateUserBetValue(string betValue, string stakeValue, string type, string gameId, string teamName)
        {
            IEnumerable<Claim> claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "FEUserID").FirstOrDefault().Value);
            BaseResult baseResult = _frontEndService.UpdateUserBetValue(betValue, stakeValue, type, gameId, teamName, userId);
            return Json(baseResult);
        }

        public JsonResult GetUserStakeValue(string teamName, string type, string gameId)
        {
            IEnumerable<Claim> claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "FEUserID").FirstOrDefault().Value);
            string stakeValue = _frontEndService.GetUserStakeValue(type, gameId, teamName, userId);
            return Json(stakeValue);
        }

        public JsonResult GetUserStakeValue1(string type, string gameId)
        {
            IEnumerable<Claim> claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "FEUserID").FirstOrDefault().Value);
            string stakeValue = _frontEndService.GetUserStakeValue_New(type, gameId, userId);
            return Json(stakeValue);
        }

        public IActionResult ChangeBtnValue()
        {
            return View();
        }

        //Dictionary<string, string> keyValuePairs
        public JsonResult UpdateBetButtonValue(Dictionary<string, string> btnValueList)
        {
            IEnumerable<Claim> claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "FEUserID").FirstOrDefault().Value);
            BaseResult baseResult = _frontEndService.UpdateBetButtonValue(btnValueList, userId);
            return Json(baseResult);
        }

    }
}