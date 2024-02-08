using Microsoft.AspNetCore.Mvc;

namespace AKLMPSTYZDotNetCore.MvcApp.Controllers
{
    public class HighChartsController : Controller
    {
        public IActionResult PieChart()
        {
            return View();
        }
    }
}
