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
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [SwaggerOperation("GetDurationType")]
        [SwaggerResponse(200, type: typeof(DurationTypeViewModel))]
        public virtual IActionResult GetDurationType()
        {
            try
            {
                var durationTypes = _durationTypeAppService.GetAllDurationType();

                durationTypes = durationTypes ?? default(IEnumerable<DurationTypeViewModel>);

                return new ObjectResult(durationTypes);
            }
            catch (Exception e)
            {
                throw new Exception("Message: " + e.Message);
            }
        }
        #endregion
    }
}