using AKLMPSTYZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AKLMPSTYZDotNetCore.MvcApp.Controllers
{
    public class HighChartsController : Controller
    {
        public IActionResult PieChart()
        {
            return View();
        }

        public IActionResult WithDataLabelsChart()
        {
            var model = new WithDataLabelsChartModel
            {
                Categories = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
                RegData = new List<double>() { 16.0, 18.2, 23.1, 27.9, 32.2, 36.4, 39.8, 38.4, 35.5, 29.2, 22.0, 17.8 },
                TalData = new List<double>() { -2.9, -3.6, -0.6, 4.8, 10.2, 14.5, 17.6, 16.5, 12.0, 6.5, 2.0, -0.9 },
            };
            return View(model);
        }

        public IActionResult RadialBarChart()
        {
            var model = new RadialBarChartModel
            {
                Categories = new List<string>() { "Norway <span class=\"f16\"><span id=\"flag\" class=\"flag no\"></span></span>",
    "United States <span class=\"f16\"><span id=\"flag\" class=\"flag us\"></span></span>",
    "Germany <span class=\"f16\"><span id=\"flag\" class=\"flag de\"></span></span>",
    "Austria <span class=\"f16\"><span id=\"flag\" class=\"flag at\"></span></span>",
    "Canada <span class=\"f16\"><span id=\"flag\" class=\"flag ca\"></span></span>" },
                Gdata = new List<int>() { 148, 113, 104, 71, 77 },
                Sdata = new List<int>() { 113, 122, 98, 88, 72 },
                Bdata = new List<int>() { 124, 95, 65, 91, 76 },
            };
            return View(model);
        }
    }
}
