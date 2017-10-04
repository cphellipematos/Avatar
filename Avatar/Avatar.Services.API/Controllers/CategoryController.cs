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
    [Route("api/v1/category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryAppService _categoryAppService;

        public CategoryController(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }


        /// <summary>
        /// Get categories
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpGet]
        [SwaggerOperation("Category")]
        [SwaggerResponse(200, type: typeof(CategoryViewModel))]
        public virtual IActionResult GetAllCategories()
        {
            try
            {
                var categories = _categoryAppService.GetAllCategories();

                if (categories == null)
                    return NoContent();

                return Ok(categories);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }

        }

        /// <summary>
        /// Create category
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="user">Created category object</param>
        /// <response code="200">Successful Operation</response>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response> 
        [HttpPost]
        [SwaggerOperation("CreateCategory")]
        public virtual IActionResult CreateCategory(CategoryViewModel category)
        {
            try
            {
                _categoryAppService.CreateCategory(category);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }


        }
    }
}