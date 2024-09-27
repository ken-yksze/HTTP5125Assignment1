using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Returns the start of a knock knock joke
        /// </summary>
        /// <returns>
        /// The string "Who’s there?"
        /// </returns>
        /// <example>
        /// POST: https://localhost:xx/api/q4/knockknock
        /// HEADERS: (NONE)
        /// BODY: (NONE)
        /// -> "Who’s there?"
        /// curl -d "" "https://localhost:xx/api/q4/knockknock"
        /// </example>
        [HttpPost(template: "KnockKnock")]
        public string KnockKnock()
        {
            string message = "Who’s there?";
            return message;
        }
    }
}
