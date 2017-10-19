using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Avatar.Application.ViewModel;
using Avatar.Application.Interfaces;
using Avatar.Infra.Data.Repository.Interfaces;

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
        /// <response code="0">successful operation</response>
        [HttpPost]
        [SwaggerOperation("CreateCompany")]
        public virtual IActionResult CreateCompany(CompanyViewModel company)
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
        /// Delete company
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="id">The company that needs to be deleted</param>
        /// <response code="200">OK</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpDelete]
        [Route("/{id}")]
        [SwaggerOperation("DeleteCompany")]
        [SwaggerResponse(200, type: typeof(CompanyViewModel))]
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
        /// Get Companies
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [SwaggerOperation("GetCompanies")]
        [SwaggerResponse(200, type: typeof(CompanyViewModel))]
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
        /// Get company
        /// </summary>
        /// <remarks></remarks>
        /// <param name="id">Return Company</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [Route("/{id}")]
        [SwaggerOperation("GetCompanyById")]
        [SwaggerResponse(200, type: typeof(CompanyViewModel))]
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
        /// Updated company
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>       
        /// <param name="company">Updated company object</param>
        /// <response code="200">OK</response>
        /// <response code="400">Invalid user supplied</response>
        /// <response code="404">User not found</response>
        [HttpPut]
        [SwaggerOperation("UpdateCompany")]
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