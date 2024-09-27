using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// Returns an acknowledgement of the {secret} integer
        /// </summary>
        /// <param name="secret">
        /// The {secret} to acknowledge
        /// </param>
        /// <returns>
        /// The string "Shh.. the secret is {secret}"
        /// </returns>
        /// <example>
        /// POST: https://localhost:xx/api/q5/secret
        /// HEADERS: Content-Type: application/json
        /// BODY: 5
        /// -> "Shh.. the secret is 5"
        /// curl -H "Content-Type: application/json" -d "5" "https://localhost:xx/api/q5/secret"
        /// 
        /// POST: https://localhost:xx/api/q5/secret
        /// HEADERS: Content-Type: application/json
        /// BODY: -200
        /// -> "Shh.. the secret is -200"
        /// curl -H "Content-Type: application/json" -d "-200" "https://localhost:xx/api/q5/secret"
        /// </example>
        [HttpPost(template: "Secret")]
        [Consumes("application/json")]
        public string Secret([FromBody] int secret)
        {
            string acknowledgementMessage = $"Shh.. the secret is {secret}";
            return acknowledgementMessage;
        }
    }
}
