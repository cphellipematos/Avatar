using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Avatar.Application.ViewModel;
using Newtonsoft.Json;
using Avatar.Application.Interfaces;
using System.Net.Http;  
using System.Net;


namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/user")]
    public class UserController : Controller
    {
        private readonly IUserAppService _userAppService;
        private readonly ICategoryAppService _categoryAppService;

        public UserController(IUserAppService userAppService, ICategoryAppService categoryAppService)
        {
            _userAppService = userAppService;
            _categoryAppService = categoryAppService;
            _responseMessage = new TaskCompletionSource<HttpResponseMessage>();
        }
        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="user">Created user object</param>
        /// <response code="200">Successful Operation</response>
        /// <response code="400">Bad Request</response> 
        [HttpPost]
        [SwaggerOperation("CreateUser")]
        public virtual IActionResult CreateUser(UserViewModel user)
        {
            try
            {
                var testeuser = new UserViewModel();
                
                // CHANGE METHOD TO RETURN INSERTED USER
                _userAppService.CreateUser(user);
                
                return Ok(testeuser);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        
        }


        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="id">The user id that needs to be deleted</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response> 
        [HttpDelete]
        [Route("{id}")]
        [SwaggerOperation("DeleteUser")]
        public virtual IActionResult DeleteUser([FromRoute]int id)
        {
            try
            {
                _userAppService.DeleteUser(id);

                return Ok("User was deleted with success!");
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }


        /// <summary>
        /// Get user by id
        /// </summary>
        /// <remarks></remarks>
        /// <param name="id">Return User</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad Request</response> 
        [HttpGet]
        [Route("{id}")]
        [SwaggerOperation("GetUserById")]
        [SwaggerResponse(200, type: typeof(UserViewModel))]
        public virtual IActionResult GetUserById([FromRoute]int id)
        {
            try
            {
                var user = _userAppService.GetUserById(id);

                user = user ?? default(UserViewModel);

                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
            
        }

        /// <summary>
        /// Get users
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">successful operation</response>
        /// <response code="400">Bad Request</response> 
        [HttpGet]
        [SwaggerOperation("GetUsers")]
        [SwaggerResponse(200, type: typeof(UserViewModel))]
        public virtual IActionResult GetUsers()
        {
            try
            {
                var users = _userAppService.GetAllUsers();

                users = users ?? default(IEnumerable<UserViewModel>);

                return Ok(users);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }           
        }


        /// <summary>
        /// Updated user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="id">id of user that need to be updated</param>
        /// <param name="user">Updated user object</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response> 
        [HttpPut]
        [SwaggerOperation("UpdateUser")]
        public virtual IActionResult UpdateUser([FromBody]UserViewModel user)
        {
            try
            {
                var userChanged = _userAppService.UpdateUser(user);

                userChanged = userChanged ?? default(UserViewModel);

                return Ok(userChanged);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }

    }
}