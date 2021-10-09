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

                    if (result.IsSuccess == true)
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
                            new Claim("FEBalance", result.Balance)
                        };

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
            var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value);
            BaseResult result = _frontEndService.CheckOldPassword(oldPassword, userId);
            return Json(result);
        }


        [HttpPost]
        public JsonResult ChangePassword(string NewPassword)
        {
            var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value);
            BaseResult result = _frontEndService.ChangePassword(NewPassword, userId);
            return Json(result);
        }

    }
}