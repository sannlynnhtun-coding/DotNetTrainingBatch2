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
        public IActionResult Linechart()
        {
            var model = new ChartJSLineChartModel
            {
                Labeldata = new List<string> { "January", "February", "March", "April", "May", "June", "July" },
                DataSetName = new List<string> { "My First Dataset" },
                DataSetData = new List<int> { 65, 59, 80, 81, 56, 55, 85 },
            };
            return View(model);

        }
        public IActionResult RadarChart()
        {
            var model = new RadarChartModel
            {
                Labeldata = new List<string> { "Eating", "Drinking", "Sleeping", "Designing", "Coding", "Cycling", "Running" },
                DataSetName = new List<string> { "My First DataSet", "My Second DataSet" },
                DataSetData1 = new List<int> { 65, 59, 90, 81, 56, 55, 40 },
                DataSetData2 = new List<int> { 28, 48, 40, 19, 96, 27, 100 }
            };
            return View(model);
        }
    }
}
