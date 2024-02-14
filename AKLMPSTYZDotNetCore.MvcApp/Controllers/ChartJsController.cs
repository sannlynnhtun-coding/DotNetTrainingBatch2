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

        #region Bubble Chart
        public IActionResult JSBubbleChart()
        {
            var model = new JSBubbleChartModel
            {
                Label = "First Dataset",
                Data = new List<JSBubbleChartData>
                {
                    new JSBubbleChartData { X = 20, Y = 30, R = 15 },
                    new JSBubbleChartData { X = 40, Y = 10, R = 10 }
                },
                BackgroundColor = "rgb(255, 99, 132)"
            };

            return View(model);
        }

        #endregion

        #region BarChart
        public IActionResult BarChartJS()
    {
        var model = new BarChartJSModel
        {
            Labels = new[] { "January", "February", "March", "April", "May", "June", "July" },
            Data = new[] { 65, 59, 80, 81, 56, 55, 40 }
        };
        return View(model);
    }
        #endregion
    }
}
