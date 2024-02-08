using AKLMPSTYZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AKLMPSTYZDotNetCore.MvcApp.Controllers
{
    public class ApexChartController : Controller
    {
        public IActionResult PieChart()
        {
            var model = new PieChartModel()
            {
                Lables = new List<string>() { "Team A", "Team B", "Team C", "Team D", "Team E" },
                Series = new List<int>() { 44, 55, 13, 43, 22 },
            };
            return View(model);
        }
        public IActionResult BarChart()
        {
            var model = new BarChartModel()
            {
                Lables = new List<string>() { "South Korea", "Canada", "United Kingdom", "Netherlands", "Italy", "France", "Japan", "United States", "China", "Germany" },
                Series = new List<int>() { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 },
            };
            return View(model);
        }
        public IActionResult LineChart()
        {
            var model = new LineChartModel()
            {
                Name = "High - 2013",
                Data = new List<int>() { 28, 29, 33, 36, 32, 32, 33 },
                Categories = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" }
            };

            return View(model);
        }
    }
}
