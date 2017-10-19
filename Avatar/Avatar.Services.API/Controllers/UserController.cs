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
using Avatar.Infra.Data.Repository.Interfaces;

namespace Avatar.Services.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/user")]
    public class UserController : BaseController
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService, IUnitOfWork uow)
            :base(uow)
        {
            _userAppService = userAppService;
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
                var serverCommand = _userAppService.CreateUser(user);
                return ReturnResponse(serverCommand, user, null);

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
                var serverCommand = _userAppService.DeleteUser(id);
                return ReturnResponse(serverCommand, "User Deleted!", null);
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
               var command = _userAppService.GetUserById(id);
               return ReturnResponse(command, command, null);
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
        public virtual IActionResult GetAllUsers()
        {
            try
            {
                var usersCommand = _userAppService.GetAllUsers();
                return ReturnResponse(usersCommand);
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
                var userCommand = _userAppService.UpdateUser(user);

                return ReturnResponse(userCommand, userCommand, null);
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e.Message);
            }
        }

    }
}