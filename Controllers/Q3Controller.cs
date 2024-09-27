using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// Returns the cube of the integer {num}
        /// </summary>
        /// <param name="num">
        /// The base {num} to cube
        /// </param>
        /// <returns>
        /// The integer {num} ^ 3
        /// </returns>
        /// <example>
        /// GET: https://localhost:xx/api/q3/cube/4 -> 64
        /// GET: https://localhost:xx/api/q3/cube/-4 -> -64
        /// GET: https://localhost:xx/api/q3/cube/10 -> 1000
        /// </example>
        [HttpGet(template: "Cube/{num}")]
        public int Cube(int num)
        {
            int cubic = (int)Math.Pow(num, 3);
            return cubic;
        }
    }
}
