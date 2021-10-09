using Dream14.Core.DomainServices;
using Dream14.Core.Helper;
using Dream14.ViewModels.Global;
using Dream14.ViewModels.SuperAdmin;
using Microsoft.AspNetCore.Authorization;
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
    public class SuperAdminController : Controller
    {

        #region Private Member

        /// <summary>
        /// IAuthService data member
        /// </summary>
        private readonly IAdminService _adminService;

        /// <summary>
        /// IAuthService data member
        /// </summary>
        private readonly IApiService _apiService;


        /// <summary>
        /// ILogger data member
        /// </summary>
        private readonly ILogger<SuperAdminController> _logger;

        #endregion


        #region Constructor

        /// <summary>
        /// SuperAdminController constructor
        /// </summary>
        /// <param name="adminService">admin service object</param>
        /// <param name="logger">loggwr object</param>
        public SuperAdminController(IAdminService adminService, IApiService apiService, ILogger<SuperAdminController> logger)
        {
            _adminService = adminService;
            _apiService = apiService;
            _logger = logger;
            GetApiList();
        }

        #endregion


        public IActionResult EventList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangeUserStatus(int id)
        {
            BaseResult result = new BaseResult();

            try
            {
                result = _adminService.ChangeUserStatus(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Ok(result);
            }
        }

        public JsonResult GetApiList()
        {
            Task<List<Cricket>> result= _apiService.GetApiListAsync();
            return Json(result.Result);
        }

        public JsonResult GetEventDetail(string gameId)
        {
            Task<EventDetail> result = _apiService.GetEventDetailAsync(gameId);
            return Json(result.Result);
        }

        public IActionResult EventDetail()
        {
            return View();
        }


        #region Admin Users

        public IActionResult AdminUsers()
        {
            var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int createdBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value);
            return View(_adminService.GetAllAdminUsers(createdBy));
        }

        public IActionResult AddAdminUser()
        {
            AdminUser adminUser = new AdminUser();
            return View(adminUser);
        }

        public JsonResult CheckUserNameExists(string userName)
        {
            BaseResult result = null;

            try
            {
                result = _adminService.CheckUserNameExists(userName);
                return Json(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Json(result);
            }
        }

        [HttpPost]
        public JsonResult AddAdminUser(string Name, string UserName, string Password, string MobileNumber)
        {
            BaseResult result = null;

            try
            {
                var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
                AdminUser adminUser = new AdminUser
                {
                    Name = Name,
                    UserName = UserName,
                    Password = Password,
                    MobileNumber = MobileNumber,
                    CreatedBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value),
                    RoleName = "Admin"
                };
                result = _adminService.SaveAdminUser(adminUser);

                return Json(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Json(result);
            }

        }

        public IActionResult EditAdminUser(int id)
        {
            try
            {
                AdminUser adminUser = _adminService.GetAdminUserById(id);
                return View(adminUser);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                return View("/Error");
            }
        }

        [HttpPost]
        public IActionResult EditAdminUser(string Name, string UserName, string Password, int userId, string MobileNumber)
        {
            BaseResult result = null;

            try
            {
                var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
                AdminUser adminUser = new AdminUser
                {
                    Name = Name,
                    UserName = UserName,
                    Password = Password,
                    UserId = userId,
                    MobileNumber = MobileNumber,
                    ModifiedBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value)
                };
                result = _adminService.UpdateAdminUser(adminUser);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Ok(result);
            }
        }

        [HttpPost]
        public IActionResult ChangeAdminUserStatus(string status, int userId)
        {
            BaseResult result = new BaseResult();

            try
            {
                result = _adminService.ChangeAdminUserStatus(status, userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Ok(result);
            }
        }

        #endregion


        #region Master Users

        public IActionResult MasterUsers()
        {
            var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int createdBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value);
            return View(_adminService.GetAllMasterUsers(createdBy));
        }

        public IActionResult AddMasterUser()
        {
            MasterUser masterUser = new MasterUser();
            return View(masterUser);
        }

        [HttpPost]
        public JsonResult AddMasterUser(string Name, string UserName, string Password, string MobileNumber)
        {
            BaseResult result = null;

            try
            {
                var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
                MasterUser adminUser = new MasterUser
                {
                    Name = Name,
                    UserName = UserName,
                    Password = Password,
                    CreatedBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value),
                    MobileNumber = MobileNumber,
                    RoleName = "Master"
                };
                result = _adminService.SaveMasterUser(adminUser);

                return Json(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Json(result);
            }

        }

        public IActionResult EditMasterUser(int id)
        {
            try
            {
                MasterUser adminUser = _adminService.GetMasterUserById(id);
                return View(adminUser);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                return View("/Error");
            }
        }

        [HttpPost]
        public IActionResult EditMasterUser(string Name, string UserName, string Password, int UserId, string MobileNumber)
        {
            BaseResult result = null;

            try
            {
                var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
                MasterUser adminUser = new MasterUser
                {
                    Name = Name,
                    UserName = UserName,
                    Password = Password,
                    UserId = UserId,
                    MobileNumber = MobileNumber,
                    ModifiedBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value)
                };
                result = _adminService.UpdateMasterUser(adminUser);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Ok(result);
            }
        }

        [HttpPost]
        public IActionResult ChangeMasterUserStatus(string status, int userId)
        {
            BaseResult result = new BaseResult();

            try
            {
                result = _adminService.ChangeMasterUserStatus(status, userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Ok(result);
            }
        }

        #endregion


        #region Agent Users

        public IActionResult AgentUsers()
        {
            var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int createdBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value);
            return View(_adminService.GetAllAgentUsers(createdBy));
        }

        public IActionResult AddAgentUser()
        {
            AgentUser agentUser = new AgentUser();
            return View(agentUser);
        }

        [HttpPost]
        public JsonResult AddAgentUser(string Name, string UserName, string Password, string MobileNumber)
        {
            BaseResult result = null;

            try
            {
                var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
                AgentUser agentUser = new AgentUser
                {
                    Name = Name,
                    UserName = UserName,
                    Password = Password,
                    CreatedBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value),
                    MobileNumber = MobileNumber,
                    RoleName = "Agent"
                };
                result = _adminService.SaveAgentUser(agentUser);

                return Json(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Json(result);
            }

        }

        public IActionResult EditAgentUser(int id)
        {
            try
            {
                AgentUser agentUser = _adminService.GetAgentUserById(id);
                return View(agentUser);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                return View("/Error");
            }
        }

        [HttpPost]
        public IActionResult EditAgentUser(string Name, string UserName, string Password, int UserId, string MobileNumber)
        {
            BaseResult result = null;

            try
            {
                var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
                AgentUser agentUser = new AgentUser
                {
                    Name = Name,
                    UserName = UserName,
                    Password = Password,
                    UserId = UserId,
                    MobileNumber = MobileNumber,
                    ModifiedBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value)
                };
                result = _adminService.UpdateAgentUser(agentUser);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Ok(result);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult ChangeAgentUserStatus(string status, int userId)
        {
            BaseResult result = new BaseResult();

            try
            {
                result = _adminService.ChangeAgentUserStatus(status, userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Ok(result);
            }
        }

        #endregion


        #region FrontEnd Users

        public IActionResult FrontEndUsers()
        {
            var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            int createdBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value);
            return View(_adminService.GetAllFrontEndUsers(createdBy));
        }

        public IActionResult AddFrontEndUser()
        {
            FrontEndUser frontEndUser = new FrontEndUser();
            return View(frontEndUser);
        }

        [HttpPost]
        public JsonResult AddFrontEndUser(string Name, string UserName, string Password, string MobileNumber)
        {
            BaseResult result = null;

            try
            {
                var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
                FrontEndUser frontEndUser = new FrontEndUser
                {
                    Name = Name,
                    UserName = UserName,
                    Password = Password,
                    CreatedBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value),
                    MobileNumber = MobileNumber,
                    RoleName = "FrontEnd"
                };
                result = _adminService.SaveFrontEndUser(frontEndUser);

                return Json(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Json(result);
            }

        }

        public IActionResult EditFrontEndUser(int id)
        {
            try
            {
                FrontEndUser frontEndUser = _adminService.GetFrontEndUserById(id);
                return View(frontEndUser);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                return View("/Error");
            }
        }

        [HttpPost]
        public IActionResult EditFrontEndUser(string Name, string UserName, string Password, int UserId, string MobileNumber)
        {
            BaseResult result = null;

            try
            {
                var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
                FrontEndUser frontEndUser = new FrontEndUser
                {
                    Name = Name,
                    UserName = UserName,
                    Password = Password,
                    UserId = UserId,
                    MobileNumber = MobileNumber,
                    ModifiedBy = Convert.ToInt32(claims.Where(x => x.Type == "UserID").FirstOrDefault().Value)
                };
                result = _adminService.UpdateFrontEndUser(frontEndUser);

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Ok(result);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult ChangeFrontEndUserStatus(string status, int userId)
        {
            BaseResult result = new BaseResult();

            try
            {
                result = _adminService.ChangeFrontEndUserStatus(status, userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError((int)EventLevel.Error, ex, ex.Message);
                result = new BaseResult
                {
                    Message = StaticResource.InternalServerMessage
                };
                return Ok(result);
            }
        }

        #endregion
    }
}
