using DotNetTrainingBatch2.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using static DotNetTrainingBatch2.MvcApp.Models.KKChartsModel;

namespace DotNetTrainingBatch2.MvcApp.Controllers
{
    public class ChartJsController : Controller
    {
        public IActionResult ColumnChart()
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
        public IActionResult HorizontalBarChart()
        {
            return View();
        }

        #region HoriBarChart
        public IActionResult HoribarChart()
        {
            var data = new KKChartsModel.KKHoriBarModel()
            {
                labels = new List<string>() { "Most loved languages" },
                datasets = new List<KKChartsModel.KKHoriBarDataSetModel>()
                {
                    new KKChartsModel.KKHoriBarDataSetModel()
                    {
                        label = "Rust",
                        data = new List<int>(){ 83 },
                        backgroundColor = "#8bca84",
                        borderColor = "#3b8132"
                    },
                    new KKChartsModel.KKHoriBarDataSetModel()
                    {
                        label = "Python",
                        data = new List<int>(){ 76 },
                        backgroundColor = "#8bca84",
                        borderColor = "#3b8132"
                    }
                    ,new KKChartsModel.KKHoriBarDataSetModel()
                    {
                        label = "Typescript",
                        data = new List<int>(){ 68 },
                        backgroundColor = "#8bca84",
                        borderColor = "#3b8132"
                    }
                    ,new KKChartsModel.KKHoriBarDataSetModel()
                    {
                        label = "Web Assembly",
                        data = new List<int>(){ 64 },
                        backgroundColor = "#8bca84",
                        borderColor = "#3b8132"
                    }
                    ,new KKChartsModel.KKHoriBarDataSetModel()
                    {
                        label = "Elixar",
                        data = new List<int>(){ 52 },
                        backgroundColor = "#8bca84",
                        borderColor = "#3b8132"
                    },
                }
            };
            return View(data);
        }
        #endregion

        #region BubbleChart
        public IActionResult BubbleChart()
        {
            var model = new BubbleChartData
            {
                DataSets = new List<BubbleChartData.BubbleDataSet>
            {
                new BubbleChartData.BubbleDataSet
                {
                    Label = "First Dataset",
                    DataPoints = new List<BubbleChartData.BubbleDataPoint>
                    {
                        new BubbleChartData.BubbleDataPoint { X = 20, Y = 30, R = 15 },
                        new BubbleChartData.BubbleDataPoint { X = 40, Y = 10, R = 10 }
                    }
                },
                new BubbleChartData.BubbleDataSet
                {
                    Label = "Second Dataset",
                    DataPoints = new List<BubbleChartData.BubbleDataPoint>
                    {
                        new BubbleChartData.BubbleDataPoint { X = 30, Y = 40, R = 20 },
                        new BubbleChartData.BubbleDataPoint { X = 50, Y = 20, R = 15 }
                    }
                }
            }
            };

            return View(model);
        }
        #endregion

        #region Doughnut
        public IActionResult Doughnut()
        {
            var model = new Doughnut
            {
                Label = "My First Dataset",
                BackgroundColor = new List<string> { "rgb(255, 99, 132)", "rgb(54, 162, 235)", "rgb(255, 205, 86)" },
                Data = new List<int> { 65, 59, 80, 81 }
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
    }
}
