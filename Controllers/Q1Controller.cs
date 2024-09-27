using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message
        /// </summary>
        /// <returns>
        /// The string "Welcome to 5125!"
        /// </returns>
        /// <example>
        /// GET: https://localhost:xx/api/q1/welcome -> "Welcome to 5125!"
        /// </example>
        [HttpGet(template: "Welcome")]
        public string Welcome()
        {
            string welcomeMessage = "Welcome to 5125!";
            return welcomeMessage;
        }
    }
}
