using Dream14.Core.DomainServices;
using Dream14.ViewModels.Global;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Dream14.WebAdmin.Controllers
{
    public class EventController : Controller
    {
        #region Private Member

        /// <summary>
        /// IEventService data member
        /// </summary>
        private readonly IEventService _eventService;

        /// <summary>
        /// ILogger data member
        /// </summary>
        private readonly ILogger<EventController> _logger;

        #endregion

        #region Constructor

        /// <summary>
        /// SuperAdminController constructor
        /// </summary>
        /// <param name="eventService">event service object</param>
        /// <param name="logger">loggwr object</param>
        public EventController(IEventService eventService, ILogger<EventController> logger)
        {
            _eventService = eventService;
            _logger = logger;
        }

        #endregion


        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetEventsList()
        {
            string roleName = GetUserRole();
            string userType = GetUserType();
            CricketList result = _eventService.GetEventList(roleName, userType);
            return Json(result);
        }

        public IActionResult EventDetail()
        {
            return View();
        }

        public JsonResult GetEventDetail(string gameId)
        {
            string roleName = GetUserRole();
            EventDetail eventDetail = _eventService.GetEventDetail(roleName, gameId);
            return Json(eventDetail);
        }

        public JsonResult ChangeEventsStatus(List<Cricket> cricketList)
        {
            BaseResult result = _eventService.ChangeEventsStatus(cricketList);
            return null;
        }


        private string GetUserRole()
        {
            var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            string roleName = claims.Where(x => x.Type == ClaimTypes.Role).Select(r => r.Value).FirstOrDefault();
            return roleName;
        }

        private string GetUserType()
        {
            var claims = (HttpContext.User.Identity as ClaimsIdentity).Claims;
            string roleName = claims.Where(x => x.Type == "UserType").FirstOrDefault().Value;
            return roleName;
        }
    }
}