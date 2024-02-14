using AKLMPSTYZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

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

        public IActionResult BasicBarChart()
        {
            string json = @"[
    {
        'Name': ""Year 1990"",
        'Data': [631, 727, 3202, 721]
    },
    {
        'Name': ""Year 2000"",
        'Data': [814, 841, 3714, 726]
    }
]";


            List<BasicBarChartDataSeriesModel> deserializedList = JsonConvert.DeserializeObject<List<BasicBarChartDataSeriesModel>>(json)!;

            BasicBarChartModel viewModel = new()
            {
                Series = deserializedList
            };

            return View(viewModel);
        }

        public IActionResult PercentageAreaChart()
        {
            string json = @"[
    {
        'name': ""China"",
        'data': [
            2.5, 2.6, 2.7, 2.9, 3.1, 3.4, 3.5, 3.5, 3.4, 3.4, 3.4,
            3.5, 3.9, 4.5, 5.2, 5.9, 6.5, 7, 7.5, 7.9, 8.6, 9.5, 9.8,
            10, 10, 9.8, 9.7, 9.9, 10.3, 10.5, 10.7, 10.9
        ]
    },
    {
        'name': ""USA"",
        'data':[5.1, 5.1, 5.2, 5.3, 5.4, 5.4, 5.6, 5.7, 5.7, 5.8, 6, 5.9,
                    5.9, 6, 6.1, 6.1, 6.1, 6.1, 5.9, 5.5, 5.7, 5.5, 5.3, 5.5,
                    5.5, 5.4, 5.2, 5.2, 5.4, 5.3, 4.7, 5
        ]
    }
]";

            List<PercentageAreaChartSeriesModel> deserializedList = JsonConvert.DeserializeObject<List<PercentageAreaChartSeriesModel>>(json)!;

            PercentageAreaChartModel model = new()
            {
                Series = deserializedList
            };
            return View(model);
        }

        #region SplineWithInvertedAxesChart
        public IActionResult SplineWithInvertedAxesChart()
        {
            var model = new SplineWithInvertedAxesChartModel
            {
                Title = "Atmosphere Temperature by Altitude",
                Subtitle = "According to the Standard Atmosphere Model",
                Series = new List<SeriesData>
                {
                    new SeriesData
                    {
                        Name = "Temperature",
                        Data = new List<PointData>
                        {
                            new PointData { X = 0, Y = 15 },
                            new PointData { X = 10, Y = -50 },
                            new PointData { X = 20, Y = -56.5 },
                            new PointData { X = 30, Y = -46.5 },
                            new PointData { X = 40, Y = -22.1 },
                            new PointData { X = 50, Y = -2.5 },
                            new PointData { X = 60, Y = -27.7 },
                            new PointData { X = 70, Y = -55.7 },
                            new PointData { X = 80, Y = -76.5 }
                        }
                    }
                }
            };

            return View(model);
        }
        #endregion

        #region LogarithmicAxisChart
        public IActionResult LogarithmicAxisChart()
        {
            var model = new LogarithmicAxisChartModel
            {
                Title = "Logarithmic Axis Demo",
                Data = new List<int> { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 },
                PointStart = 1
            };

            return View(model);
        }
        #endregion

    }
}
