using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // POST api/<UsersController>/register
        [HttpPost("register")]
        public IActionResult Register([FromBody] object data)
        {
            Console.WriteLine("register ...");
            // Implement the logic to handle the registration using the provided data
            // Example: Extract relevant properties from the 'data' object and perform necessary operations
            // Return an appropriate response based on the success or failure of the registration process
            return Ok("User registered successfully.");
        }

        // POST api/<UsersController>/login
        [HttpPost("login")]
        public IActionResult Login([FromBody] object data)
        {
            Console.WriteLine("login");
            // Implement the logic to handle the login using the provided data
            // Example: Extract relevant properties from the 'data' object and perform necessary operations
            // Return an appropriate response based on the success or failure of the login process
            return Ok("User logged in successfully.");
        }
    }
}
