using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting to {name}
        /// </summary>
        /// <param name="name">
        /// The {name} to greet
        /// </param>
        /// <returns>
        /// The string "Hi {name}!"
        /// </returns>
        /// <example>
        /// GET: https://localhost:xx/api/q2/greeting?name=Gary -> "Hi Gary!"
        /// GET: https://localhost:xx/api/q2/greeting?name=Ren%C3%A9e  "Hi Renée!"
        /// </example>
        [HttpGet(template: "Greeting")]
        public string Greeting(string name)
        {
            string greetingMessage = $"Hi {name}!";
            return greetingMessage;
        }
    }
}
