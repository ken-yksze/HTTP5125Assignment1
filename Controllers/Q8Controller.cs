using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace HTTP5125Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {
        public static readonly double SmallPrice = 25.5;
        public static readonly double LargePrice = 40.5;
        public static readonly CultureInfo CACultureInfo = CultureInfo.CreateSpecificCulture("en-CA");
        public static readonly string SmallPriceStr = SmallPrice.ToString("C2", CACultureInfo);
        public static readonly string LargePriceStr = LargePrice.ToString("C2", CACultureInfo);

        public class SquashFellowsOrder
        {
            public int Small { get; set; }
            public int Large { get; set; }
        }

        /// <summary>
        /// Returns the checkout summary for an order
        /// </summary>
        /// <param name="order">
        /// The {order} to summarize, which includes two int {Small} & {Large}
        /// </param>
        /// <returns>
        /// The checkout summary in string
        /// </returns>
        /// <example>
        /// POST: https://localhost:xx/api/q8/squashfellows
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// BODY: Small=1&Large=1
        /// -> "1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58"
        /// curl -H "Content-Type: application/x-www-form-urlencoded" -d "Small=1&Large=1" "https://localhost:xx/api/q8/squashfellows"
        /// 
        /// POST: https://localhost:xx/api/q8/squashfellows
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// BODY: Small=2&Large=1
        /// -> "2 Small @ $25.50 = $51.00; 1 Large @ $40.50 = $40.50; Subtotal = $91.50; Tax = $11.90 HST; Total = $103.40"
        /// curl -H "Content-Type: application/x-www-form-urlencoded" -d "Small=2&Large=1" "https://localhost:xx/api/q8/squashfellows"
        /// 
        /// POST: https://localhost:xx/api/q8/squashfellows
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// BODY: Small=100&Large=100
        /// -> "100 Small @ $25.50 = $2,550.00; 100 Large @ $40.50 = $4,050.00; Subtotal = $6,600.00; Tax = $858.00 HST; Total = $7,458.00"
        /// curl -H "Content-Type: application/x-www-form-urlencoded" -d "Small=100&Large=100" "https://localhost:xx/api/q8/squashfellows"
        /// </example>
        [HttpPost(template: "SquashFellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string SquashFellows([FromForm] SquashFellowsOrder order)
        {
            double smallTotal = order.Small * SmallPrice;
            double largeTotal = order.Large * LargePrice;
            double subTotal = smallTotal + largeTotal;
            double tax = Math.Round(subTotal * 0.13, 2);
            double total = subTotal + tax;
            string smallTotalStr = smallTotal.ToString("C2", CACultureInfo);
            string largeTotalStr = largeTotal.ToString("C2", CACultureInfo);
            string subTotalStr = subTotal.ToString("C2", CACultureInfo);
            string taxStr = tax.ToString("C2", CACultureInfo);
            string totalStr = total.ToString("C2", CACultureInfo);
            string checkoutSummary = $"{order.Small} Small @ {SmallPriceStr} = {smallTotalStr}; {order.Large} Large @ {LargePriceStr} = {largeTotalStr}; Subtotal = {subTotalStr}; Tax = {taxStr} HST; Total = {totalStr}";
            return checkoutSummary;
        }
    }
}
