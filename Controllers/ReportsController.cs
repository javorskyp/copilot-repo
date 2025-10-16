using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace MyFirstDotNetApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        /// <summary>
        /// Returns a CSV sales report aggregated per user.
        /// For demo purposes this uses in-memory sample data.
        /// </summary>
        [HttpGet("sales")]
        public IActionResult SalesCsv()
        {
            // Sample data: in a real app pull from DB
            var sales = new[]
            {
                new { UserId = 1, UserName = "Jan", Total = 150.50m },
                new { UserId = 2, UserName = "Anna", Total = 249.99m },
                new { UserId = 3, UserName = "Piotr", Total = 0m }
            };

            var csv = new StringBuilder();
            csv.AppendLine("UserId,UserName,Total");
            foreach (var s in sales)
            {
                csv.AppendLine($"{s.UserId},{Escape(s.UserName)},{s.Total}");
            }

            var bytes = Encoding.UTF8.GetBytes(csv.ToString());
            return File(bytes, "text/csv", "sales-report.csv");
        }

        private string Escape(string input)
        {
            if (input.Contains(","))
                return "\"" + input.Replace("\"", "\"\"") + "\"";
            return input;
        }
    }
}
