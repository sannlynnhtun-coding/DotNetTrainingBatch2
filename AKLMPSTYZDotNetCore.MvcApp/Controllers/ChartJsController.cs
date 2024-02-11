using AKLMPSTYZDotNetCore.MvcApp.Models;
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


        public IActionResult ScatterChart()
        {
            var model = new ScatterChartModel
            {
                Datas = new List<Data>
                {
                    new Data { X = -10, Y = 0 },
                    new Data { X = 0, Y = 10 },
                    new Data { X = 10, Y = 5 },
                    new Data { X = 0.5, Y = 5.5 }
                }
            };
            return View(model);
        }

        public IActionResult MixedChart()
        {
            var model = new MixedChartModel
            {
                Labels = new List<string>() { "January", "February", "March", "April" },
                Bdata = new List<int>() { 10, 20, 30, 40 },
                Ldata = new List<int>() { 50, 50, 50, 50 },
            };
            return View(model);
        }
    }
}
