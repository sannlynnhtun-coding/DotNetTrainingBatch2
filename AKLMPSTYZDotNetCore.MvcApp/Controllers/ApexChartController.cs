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
    }
}
