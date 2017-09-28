using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using Avatar.Application.ViewModel;
using Avatar.Application.Interfaces;

namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/company")]
    public class CompanyController : Controller
    {
        private readonly ICompanyAppService _companyAppService;

        public CompanyController(ICompanyAppService companyAppService)
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
        public virtual void CreateCompany([FromBody]CompanyViewModel company)
        {
            throw new NotImplementedException();
        }


        ///// <summary>
        ///// Delete company
        ///// </summary>
        ///// <remarks>This can only be done by the logged in user.</remarks>
        ///// <param name="id">The company that needs to be deleted</param>
        ///// <response code="200">OK</response>
        ///// <response code="400">Invalid username supplied</response>
        ///// <response code="404">User not found</response>
        //[HttpDelete]
        //[Route("/{id}")]
        //[SwaggerOperation("DeleteCompany")]
        //[SwaggerResponse(200, type: typeof(CompanyViewModel))]
        //public virtual IActionResult DeleteCompany([FromRoute]int? id)
        //{
        //    string exampleJson = null;

        //    //var example = exampleJson != null
        //    //? JsonConvert.DeserializeObject<Company>(exampleJson)
        //    //: default(Company);
        //    //return new ObjectResult(example);
        //}

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
        public virtual IActionResult GetCompanies()
        {
            try
            {
                var companies = _companyAppService.GetAllCompanies();

                companies = companies ?? default(IEnumerable<CompanyViewModel>);

                return new ObjectResult(companies);
            }
            catch (Exception e)
            {
                throw new Exception("Message: " + e.Message);
            }
        }

        ///// <summary>
        ///// Get company
        ///// </summary>
        ///// <remarks></remarks>
        ///// <param name="id">Return Company</param>
        ///// <response code="200">successful operation</response>
        ///// <response code="400">Invalid username supplied</response>
        ///// <response code="404">User not found</response>
        //[HttpGet]
        //[Route("/{id}")]
        //[SwaggerOperation("GetCompanyById")]
        //[SwaggerResponse(200, type: typeof(CompanyViewModel))]
        //public virtual IActionResult GetCompanyById([FromRoute]int? id)
        //{
        //    string exampleJson = null;

        //    //var example = exampleJson != null
        //    //? JsonConvert.DeserializeObject<User>(exampleJson)
        //    //: default(User);
        //    //return new ObjectResult(example);
        //}


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
        public virtual void UpdateCompany([FromBody]CompanyViewModel company)
        {
            throw new NotImplementedException();
        }
    }
}