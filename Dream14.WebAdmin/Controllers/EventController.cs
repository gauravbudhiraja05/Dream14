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
            _eventService.AddOrUpdateEvents();
            return View();
        }

        public JsonResult GetEventsList()
        {
            string roleName = GetUserRole();
            string userType = GetUserType();
            CricketList result = _eventService.GetEventList(roleName, userType);
            return Json(result);
        }

        public IActionResult EventDetail(string gameId)
        {
            _eventService.AddOrUpdateEventDetail(gameId);
            return View();
        }

        public JsonResult GetEventDetail(string gameId)
        {
            string roleName = GetUserRole();
            string userType = GetUserType();
            EventDetail eventDetail = _eventService.GetEventDetail(roleName, userType, gameId);
            return Json(eventDetail);
        }

        public JsonResult ChangeEventsStatus(List<Cricket> cricketList)
        {
            BaseResult result = _eventService.ChangeEventsStatus(cricketList);
            return Json(result);
        }

        public JsonResult ChangeEventDetailStatus(string eventDetailName, string gameId, string isSelected)
        {
            BaseResult result = _eventService.ChangeEventDetailStatus(eventDetailName, gameId, isSelected);
            return Json(result);
        }

        public JsonResult UpdateT3Status(List<T3> t3List)
        {
            BaseResult result = _eventService.UpdateT3Status(t3List);
            return Json(result);
        }

        public JsonResult UpdateT4Status(List<T4> t4List)
        {
            BaseResult result = _eventService.UpdateT4Status(t4List);
            return Json(result);
        }


        public JsonResult GetT3CheckBoxDetails(string gameId)
        {
            List<T3> t3List = _eventService.GetT3CheckBoxDetails(gameId);
            return Json(t3List);
        }

        public JsonResult GetT4CheckBoxDetails(string gameId)
        {
            List<T4> t4List = _eventService.GetT4CheckBoxDetails(gameId);
            return Json(t4List);
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