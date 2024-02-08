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
        public IActionResult MixedChart()
        {
            var model = new MixedChart()
            {
                Income_colum_data = new List<double> { 1.4, 2, 2.5, 1.5, 2.5, 2.8, 3.8, 4.6 },
                Cashflow_column_data = new List<double> { 1.4, 2, 2.5, 1.5, 2.5, 2.8, 3.8, 4.6 },
                Xaxis_categories = new List<int> { 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016 },
                Revenue_line = new List<int> { 20, 29, 37, 36, 44, 45, 50, 58 },
            };
            return View(model);
        }

        #region 3DbubbleChart
        public IActionResult BubbleChart()
        {
            var model = new BubbleChartModel()
            {
                Series = new List<BubbleSeries>
                {
                    new BubbleSeries
                    {
                        Name = "Product1",
                        Data = GenerateData(new DateTime(2017, 3, 11), 15, new { min = 20, max = 60 })
                    },
                    new BubbleSeries
                    {
                        Name = "Product2",
                        Data = GenerateData(new DateTime(2018, 4, 11), 15, new { min = 20, max = 60 })
                    },
                     new BubbleSeries
                    {
                        Name = "Product3",
                        Data = GenerateData(new DateTime(2019, 2, 11), 15, new { min = 20, max = 60 })
                    },


                }
            };

            return View(model);
        }

        private List<BubbleData> GenerateData(DateTime baseDate, int count, object yrange)
        {
            var i = 0;
            var data = new List<BubbleData>();
            while (i < count)
            {
                var x = (int)(new Random().Next(1, 750)); // Equivalent to Math.floor(Math.random() * (750 - 1 + 1)) + 1
                var y = (int)(new Random().Next((int)yrange.GetType().GetProperty("min").GetValue(yrange), (int)yrange.GetType().GetProperty("max").GetValue(yrange))); // Equivalent to Math.floor(Math.random() * (yrange.max - yrange.min + 1)) + yrange.min
                var z = (int)(new Random().Next(15, 75)); // Equivalent to Math.floor(Math.random() * (75 - 15 + 1)) + 15

                data.Add(new BubbleData { X = baseDate.AddDays(i), Y = y, Z = z });
                i++;
            }
            return data;
        }

        #endregion

        public IActionResult PyramidChart()
        {
            var model = new PyramidChartModel()
            {
                categories = new List<string> { "sweet", "Processed Foods", "Healthy Fats", "Meat", "Beans & Legumes", "Dairy", "Fruits & Vegetables", "Grains" },
                data = new List<int>() { 200, 330, 548, 740, 880, 990, 1100, 1320 },
            };
            return View(model);
        }
    }
}
