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
        /// <response code="200">OK</response>
        /// <response code="400">Invalid username/password supplied</response>
        //[HttpGet]
        //[SwaggerOperation("Category")]
        //[SwaggerResponse(200, type: typeof(CategoryViewModel))]
        //public virtual IActionResult GetAllCategories()
        //{
        //    try
        //    {
        //        var categories = _categoryAppService.GetAllCategories();
        //        categories = categories ?? default(IEnumerable<CategoryViewModel>);

        //        return new ObjectResult(categories);
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("Message: " + e.Message);
        //    }

        //}

        /// <summary>
        /// Get categories
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">OK</response>
        /// <response code="400">Invalid username/password supplied</response>
        [HttpGet]
        [SwaggerOperation("Category")]
        [SwaggerResponse(200, type: typeof(CategoryViewModel))]
        public virtual IActionResult GetAllCategories()
        {
            try
            {
                var categories = _categoryAppService.GetAllCategories();
                categories = categories ?? default(IEnumerable<CategoryViewModel>);

                return new ObjectResult(categories);
            }
            catch (Exception e)
            {
                throw new Exception("Message: " + e.Message);
            }

        }

        /// <summary>
        /// Create category
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="user">Created category object</param>
        /// <response code="0">successful operation</response>
        [HttpPost]
        [SwaggerOperation("CreateCategory")]
        public virtual void CreateCategory(CategoryViewModel category)
        {
            try
            {
                _categoryAppService.CreateCategory(category);
                //var newUser = _userAppService.CreateUser(user);

                //newUser = newUser ?? default(UserViewModel);

                //return new ObjectResult(newUser);
            }
            catch (Exception e)
            {
                throw new Exception("Message: " + e.Message);
            }


        }
    }
}