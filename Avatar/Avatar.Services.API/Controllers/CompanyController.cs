using System;
using Microsoft.AspNetCore.Mvc;
using Avatar.Application.Interfaces;
using Avatar.Infra.Data.Repository.Interfaces;
using Avatar.Application.ViewModel;
using Swashbuckle.AspNetCore.SwaggerGen;
using Avatar.Domain.Commands.CompanyCommands;

namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/company")]
    public class CompanyController : BaseController
    {
        private readonly ICompanyAppService _companyAppService;

        public CompanyController(ICompanyAppService companyAppService, IUnitOfWork uow)
            : base(uow)

        {
            _companyAppService = companyAppService;
        }

        /// <summary>
        /// Create Company
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="company">Created company object</param>
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpPost]
        [SwaggerOperation("PostCompany")]
        [SwaggerResponse(200, type: typeof(CreateCompanyCommand))]
        [SwaggerResponse(400, type: typeof(BadRequestObjectResult))]
        public virtual IActionResult CreateCompany([FromBody]CompanyViewModel company)
        {
            try
            {
                var companyCommand = _companyAppService.CreateCompany(company);

                return ReturnResponse(companyCommand, companyCommand, null);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }

        }

        /// <summary>
        /// Delete Company
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="id">The company id that needs to be deleted</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response> 
        [HttpDelete]
        [Route("{id}")]
        [SwaggerOperation("DeleteCompany")]
        [SwaggerResponse(200, type: typeof(DeleteCompanyCommand))]
        public virtual IActionResult DeleteCompany([FromRoute]int id)
        {
            try
            {
                var companyCommand = _companyAppService.DeleteCompany(id);

                return ReturnResponse(companyCommand, companyCommand, null);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }

        /// <summary>
        /// Get Courses
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpGet]
        [SwaggerOperation("GetCompanies")]
        [SwaggerResponse(200, type: typeof(GetAllCompaniesCommand))]
        public virtual IActionResult GetAllCompanies()
        {
            try
            {
                var companiesCommand = _companyAppService.GetAllCompanies();

                return ReturnResponse(companiesCommand);
            }
            catch (Exception e)
            {
                throw new Exception("Message: " + e.Message);
            }
        }

        /// <summary>
        /// Get Company
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpGet]
        [Route("/{id}")]
        [SwaggerOperation("GetCompany")]
        [SwaggerResponse(200, type: typeof(GetCompanyByIdCommand))]
        public virtual IActionResult GetCompanyById([FromRoute]int id)
        {
            try
            {
                var companyCommand = _companyAppService.GetCompanyById(id);

                return ReturnResponse(companyCommand, companyCommand, null);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }

        /// <summary>
        /// Update Company
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>       
        /// <param name="company">Updated company object</param>
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpPut]
        [SwaggerOperation("UpdateCompany")]
        [SwaggerResponse(200, type: typeof(UpdateCompanyCommand))]
        public virtual IActionResult UpdateCompany([FromBody]CompanyViewModel company)
        {
            try
            {
                var companyCommand = _companyAppService.UpdateCompany(company);

                return ReturnResponse(companyCommand);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }
    }
}