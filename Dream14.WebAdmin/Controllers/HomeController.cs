using Dream14.Core.DomainServices;
using Dream14.ViewModels.FrontEnd;
using Dream14.ViewModels.Global;
using Dream14.ViewModels.SuperAdmin;
using Dream14.WebAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;

namespace Dream14.WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        #region Private Member

        /// <summary>
        /// IAuthService data member
        /// </summary>
        private readonly IAdminService _adminService;


        /// <summary>
        /// ILogger data member
        /// </summary>
        private readonly ILogger<HomeController> _logger;

        #endregion

        #region Constructor

        /// <summary>
        /// HomeController constructor
        /// </summary>
        /// <param name="adminService">admin service object</param>
        /// <param name="logger">loggwr object</param>
        public HomeController(IAdminService adminService, ILogger<HomeController> logger)
        {
            _adminService = adminService;
            _logger = logger;
        }

        #endregion

        /// <summary>
        /// Get Dashboard view action
        /// </summary>
        /// <returns>Dashboard View</returns>
        public IActionResult Dashboard()
        {
            return View();
        }


        public IActionResult ChangePassword()
        {
            return PartialView("_ChangePassword");
        }

        [AllowAnonymous]
        public JsonResult ValidateOldPassword(string oldPassword)
        {
            var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value);
            bool result = _adminService.CheckValidOldPassword(oldPassword, userId);
            if (!result)
                return Json(data: "The old password does not match our records.");

            return Json(data: true);

            //return Json(result);
            //GazetersDetail details = _frontEndService.GetSelectedPostalCodeDetail(Code.TrimEnd());
            //return Json(new { details = details });
        }

        [HttpPost]
        public JsonResult ChangePasswordForLoginUser(string NewPassword, string ConfirmPassword)
        {
            var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int userId = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value);
            BaseResult result = _adminService.ChangePasswordForLoginUser(NewPassword, userId);
            return Json(result);
        }

        public IActionResult DepositWithdrawl(int id)
        {
            return PartialView("_DepositWithdrawl", _adminService.GetAmountDetail(id));
        }

        [HttpPost]
        public JsonResult DepositWithdrawl(string Balance, string Deposit, string WithDrawl, int UserId)
        {
            DepsoitWithDrawl depositWithdrawl = new DepsoitWithDrawl
            {
                UserId = UserId,
                Deposit = Deposit,
                Balance = Convert.ToString(Convert.ToInt32(Deposit) - Convert.ToInt32(WithDrawl)),
                WithDrawl = WithDrawl
            };
            BaseResult result = _adminService.SaveAmountDetail(depositWithdrawl);
            return Json(result);
        }


        [HttpPost]
        public JsonResult AddUserDetails(string Name, string MobNumber1, string MobNumber2, string City, string State, string Country)
        {
            UserDetail userDetail = new UserDetail();
            {
                userDetail.Name = Name;
                userDetail.MobileNumber1 = MobNumber1;
                userDetail.MobileNumber2 = MobNumber2;
                userDetail.City = City;
                userDetail.State = State;
                userDetail.Country = Country;
            }
            BaseResult result = _adminService.AddUserDetail(userDetail);
            return Json(result);
        }

        public JsonResult GetUserCount()
        {
            int count = _adminService.GetUserCount();
            return Json(count);
        }

        public IActionResult UserList()
        {
            return View(_adminService.GetUserList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
