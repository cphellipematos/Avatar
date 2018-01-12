using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Avatar.Application.Interfaces;
using Avatar.Infra.Data.Repository.UoW;
using Swashbuckle.AspNetCore.SwaggerGen;
using Avatar.Application.ViewModel;

namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/portfolio")]
    public class PortfolioController : BaseController
    {
        protected IPortfolioAppService _portfolioAppService;

        public PortfolioController(UnitOfWork uow, IPortfolioAppService portfolioAppService)
            :base(uow)
        {
            _portfolioAppService = portfolioAppService;
        }

        /// <summary>
        /// Get skills
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad Request</response> 
        [HttpGet]
        [SwaggerOperation("GetSkills")]
        [SwaggerResponse(200, type: typeof(IEnumerable<PortfolioViewModel>))]
        public virtual IActionResult GetSkills()
        {
            try
            {
                var portfolioCommand = _portfolioAppService.GetPortfolios();
                return ReturnResponse(portfolioCommand);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }
    
    }
}