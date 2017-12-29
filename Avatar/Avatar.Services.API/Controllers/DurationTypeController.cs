using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Avatar.Application.ViewModel;
using Avatar.Application.Interfaces;
using Avatar.Infra.Data.Repository.Interfaces;
using Avatar.Domain.Commands.DurationTypeCommands;

namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/duration/type")]
    public class DurationTypeController : BaseController
    {
        #region Properties
        private readonly IDurationTypeAppService _durationTypeAppService;
        #endregion

        #region Constructors
        public DurationTypeController(IDurationTypeAppService durationTypeAppService, IUnitOfWork uow)
            :base(uow)
        {
            _durationTypeAppService = durationTypeAppService;
        }
        #endregion

        #region Actions        
        /// <summary>
        /// Get users
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpGet]
        [SwaggerOperation("GetDurationType")]
        [SwaggerResponse(200, type: typeof(GetDurationTypeCommand))]
        public virtual IActionResult GetDurationType()
        {
            try
            {
                var durationTypesCommand = _durationTypeAppService.GetAllDurationType();

                return ReturnResponse(durationTypesCommand);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }
        #endregion
    }
}