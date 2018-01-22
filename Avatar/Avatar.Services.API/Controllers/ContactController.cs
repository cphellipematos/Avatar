using System;
using Microsoft.AspNetCore.Mvc;
using Avatar.Infra.Data.Repository.UoW;
using Swashbuckle.AspNetCore.SwaggerGen;
using Avatar.Application.ViewModel;
using Avatar.Application.Interfaces;

namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/contact")]
    public class ContactController : BaseController
    {
        private IContactAppService _contactAppService;

        public ContactController(UnitOfWork uow
                                ,IContactAppService contactAppService)
            :base(uow)
        {
            _contactAppService = contactAppService;
        }

        /// <summary>
        /// New  Contact
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="contact">Created company object</param>
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpPost]
        [SwaggerOperation("PostContact")]        
        public virtual IActionResult CreateContact([FromBody]ContactViewModel contact)
        {            
            try
            {
                var contactCommand =_contactAppService.CreateContact(contact);                

                return ReturnResponse(contactCommand, contactCommand, null);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }            
        }
    }
}