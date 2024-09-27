using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// Returns the area of a regular hexagon with side length double {side}
        /// </summary>
        /// <param name="side">
        /// The side length {side} of hexagon
        /// </param>
        /// <returns>
        /// The double 3 * (3 ^ 0.5) / 2 * ({side} ^ 2)
        /// </returns>
        /// <example>
        /// GET: https://localhost:xx/api/q6/hexagon?side=1 -> 2.598076211353316
        /// GET: https://localhost:xx/api/q6/hexagon?side=1.5 -> 5.845671475544961
        /// GET: https://localhost:xx/api/q6/hexagon?side=20 -> 1039.2304845413264
        /// </example>
        [HttpGet(template: "Hexagon")]
        public double Hexagon(double side)
        {
            double area = 3 * Math.Sqrt(3) / 2 * Math.Pow(side, 2);
            return area;
        }
    }
}
