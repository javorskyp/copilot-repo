using Microsoft.AspNetCore.Mvc;
using MyFirstDotNetApp;

namespace MyFirstDotNetApp.Controllers
{
    /// <summary>
    /// API endpoints for managing users.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Returns all users.
        /// </summary>
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                new User { Id = 1, Name = "Jan", Email = "jan@example.com" },
                new User { Id = 2, Name = "Anna", Email = "anna@example.com" }
            };
            return Ok(users);
        }

        /// <summary>
        /// Returns a user by id.
        /// </summary>
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = new User { Id = id, Name = "Jan", Email = "jan@example.com" };
            return Ok(user);
        }
    }
}
