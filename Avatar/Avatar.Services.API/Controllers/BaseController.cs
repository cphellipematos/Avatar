using Avatar.Infra.Data.Repository.Interfaces;
using DomainNotificationHelperCore.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avatar.Services.API.Controllers
{
    public class BaseController : Controller
    {
        private readonly IUnitOfWork _uow;

        public BaseController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IActionResult ReturnResponse(Command service, object success, object error)
        {
            if (service.HasNotifications())
                return BadRequest(new {
                    success = false,
                    data = error,
                    errors = service.Notifications
                });

            _uow.Commit();
            return Ok(new { success = true, data = success });
        }

        public IActionResult ReturnResponse(object success)
        {
            _uow.Commit();
            return Ok(new { success = true, data = success });
        }
    }
}
