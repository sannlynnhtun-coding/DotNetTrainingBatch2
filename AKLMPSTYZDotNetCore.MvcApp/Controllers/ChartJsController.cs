using Microsoft.AspNetCore.Mvc;

namespace AKLMPSTYZDotNetCore.MvcApp.Controllers
{
    public class ChartJsController : Controller
    {
        public IActionResult ColumnChart()
        {
            return View();
        }
        public IActionResult HorizontalBarChart()
        {
            return View();
        }
        public IActionResult PolarAreaChart()
        {
            return View();
        }
    }
}
