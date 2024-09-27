using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// Returns a string representation of the current date adjusted by {days}
        /// </summary>
        /// <param name="days">
        /// The {days} to adjust
        /// </param>
        /// <returns>
        /// The adjusted date in format "yyyy-MM-dd"
        /// </returns>
        /// <example>
        /// Assume called on January 1, 2000
        /// GET: https://localhost:xx/api/q7/timemachine?days=1 -> "2000-01-02"
        /// GET: https://localhost:xx/api/q7/timemachine?days=-1 -> "1999-12-31"
        /// </example>
        [HttpGet(template: "TimeMachine")]
        public string TimeMachine(int days)
        {
            DateTime today = DateTime.Today;
            DateTime adjustedDate = today.AddDays(days);
            string adjustedDateStr = adjustedDate.ToString("yyyy-MM-dd");
            return adjustedDateStr;
        }
    }
}
