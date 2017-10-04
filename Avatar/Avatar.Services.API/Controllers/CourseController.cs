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
    [Route("api/v1/course")]
    public class CourseController : Controller
    {
        private readonly ICourseAppService _courseAppService;
        public CourseController(ICourseAppService courseAppService)
        {
            _courseAppService = courseAppService;
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
        [SwaggerOperation("CreateCourse")]
        public virtual IActionResult CreateCompany(CourseViewModel course)
        {
            try
            {
                _courseAppService.CreateCompany(course);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Message: " + e.Message);
            }

        }

        /// <summary>
        /// Get Companies
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpGet]
        [SwaggerOperation("GetCompanies")]
        [SwaggerResponse(200, type: typeof(CompanyViewModel))]
        public virtual IActionResult GetCompanies()
        {
            try
            {
                var courses = _courseAppService.GetAllCourses();

                if (courses == null)
                    return NoContent();

                return Ok(courses);
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
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpPut]
        [SwaggerOperation("UpdateCompany")]
        public virtual void UpdateCompany([FromBody]CompanyViewModel company)
        {
            throw new NotImplementedException();
        }
    }
}