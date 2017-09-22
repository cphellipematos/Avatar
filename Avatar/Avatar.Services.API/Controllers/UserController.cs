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

namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/user")]
    public class UserController : Controller
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        /// <summary>
        /// Create user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="user">Created user object</param>
        /// <response code="0">successful operation</response>
        [HttpPost]
        [SwaggerOperation("CreateUser")]
        public virtual IActionResult CreateUser([FromBody]UserViewModel user)
        {
            try
            {
                var newUser = _userAppService.CreateUser(user);

                newUser = newUser ?? default(UserViewModel);

                return new ObjectResult(newUser);
            }
            catch (Exception e)
            {
                throw new Exception("Message: " + e.Message);
            }
        
        }


        /// <summary>
        /// Delete user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="id">The user id that needs to be deleted</param>
        /// <response code="200">OK</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpDelete]
        [Route("{id}")]
        [SwaggerOperation("DeleteUser")]
        public virtual void DeleteUser([FromRoute]int id)
        {
            try
            {
                _userAppService.DeleteUser(id);
            }
            catch (Exception e)
            {
                throw new Exception("Message: "+ e.Message);
            }
        }


        /// <summary>
        /// Get user by id
        /// </summary>
        /// <remarks></remarks>
        /// <param name="id">Return User</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
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

                return new ObjectResult(user);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        /// <summary>
        /// Get users
        /// </summary>
        /// <remarks></remarks>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid username supplied</response>
        /// <response code="404">User not found</response>
        [HttpGet]
        [SwaggerOperation("GetUsers")]
        [SwaggerResponse(200, type: typeof(UserViewModel))]
        public virtual IActionResult GetUsers()
        {
            try
            {
                var users = _userAppService.GetAllUsers();

                users = users ?? default(IEnumerable<UserViewModel>);

                return new ObjectResult(users);
            }
            catch (Exception e)
            {
                throw new Exception("Message: " + e.Message);
            }           
        }


        /// <summary>
        /// Updated user
        /// </summary>
        /// <remarks>This can only be done by the logged in user.</remarks>
        /// <param name="id">id of user that need to be updated</param>
        /// <param name="user">Updated user object</param>
        /// <response code="200">OK</response>
        /// <response code="400">Invalid user supplied</response>
        /// <response code="404">User not found</response>
        [HttpPut]
        [SwaggerOperation("UpdateUser")]
        public virtual IActionResult UpdateUser([FromBody]UserViewModel user)
        {
            try
            {
                var userChanged = _userAppService.UpdateUser(user);

                userChanged = userChanged ?? default(UserViewModel);

                return new ObjectResult(userChanged);
            }
            catch (Exception e)
            {
                throw new Exception("Message: " + e.Message);
            }
        }
    }
}