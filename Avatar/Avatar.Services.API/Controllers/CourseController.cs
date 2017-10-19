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
using Avatar.Domain.Commands.CourseCommands;

namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/course")]
    public class CourseController : BaseController
    {
        private readonly ICourseAppService _courseAppService;
        public CourseController(ICourseAppService courseAppService, IUnitOfWork uow)
            : base(uow)

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
        public virtual IActionResult CreateCourse(CourseViewModel course)
        {
            try
            {
                var courseCommand = _courseAppService.CreateCourse(course);

                return ReturnResponse(courseCommand, courseCommand, null);
            }
            catch (Exception e)
            {
                return BadRequest("Message: " + e.Message);
            }

        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="id">The course id that needs to be deleted</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response> 
        [HttpDelete]
        [Route("{id}")]
        [SwaggerOperation("DeleteCourse")]
        public virtual IActionResult DeleteCourse([FromRoute]int id)
        {
            try
            {
                var serverCommand = _courseAppService.DeleteCourse(id);
                return ReturnResponse(serverCommand, "Course Deleted!", null);
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
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpGet]
        [SwaggerOperation("GetCourses")]
        [SwaggerResponse(200, type: typeof(GetAllCourseCommand))]
        public virtual IActionResult GetAllCourses()
        {
            try
            {
                var coursesCommand = _courseAppService.GetAllCourses();

                return ReturnResponse(coursesCommand);
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
        [SwaggerOperation("UpdateCourse")]
        public virtual IActionResult UpdateCompany([FromBody]CourseViewModel course)
        {
            try
            {
                var courseCommand = _courseAppService.UpdateCourse(course);

                return ReturnResponse(courseCommand, courseCommand, null);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);              
            }
        }
    }
}