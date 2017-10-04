using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Avatar.Application.ViewModel;
using Avatar.Application.Interfaces;

namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/duration/type")]
    public class DurationTypeController : Controller
    {
        #region Properties
        private readonly IDurationTypeAppService _durationTypeAppService;
        #endregion

        #region Constructors
        public DurationTypeController(IDurationTypeAppService durationTypeAppService)
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
        [SwaggerResponse(200, type: typeof(DurationTypeViewModel))]
        public virtual IActionResult GetDurationType()
        {
            try
            {
                var durationTypes = _durationTypeAppService.GetAllDurationType();


                if (durationTypes == null)
                    return NoContent();

                return Ok(durationTypes);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }
        #endregion
    }
}