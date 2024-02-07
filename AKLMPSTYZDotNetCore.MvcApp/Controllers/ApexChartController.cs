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
    }
}
