using AKLMPSTYZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using static AKLMPSTYZDotNetCore.MvcApp.Models.KKChartsModel;

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

        public IActionResult AudioBoxplotChart()
        {
            var model = new AudioBoxplotChartModel()
            {
                Title = new List<string> { "Exam scores per class" },
                Subtitle = new List<string> { "Click each box to sonify on its own" },
            };
            return View(model);
        }
        public IActionResult BulletGraphChart()
        {
            var model = new BulletGraphChartModel()
            {
                Title = new List<string> { "2017 YTD" },
            };
            return View(model);
		}


        #region SemiCircleChart
        public IActionResult SemiCircleChart()
		{
			var data = new KKSemiCircleModel()
			{
				Title = "Components of atmosphere",
				Name = "Concentration",
				Data = new List<List<object>>()
				{
					new List<object>()
					{
						"Nitrogen",78
					},new List<object>()
					{
						"Oxygen",20.9
					},new List<object>()
					{
						"Other",0.17
					},new List<object>()
					{
						"Argon",0.90
					},new List<object>()
					{
						"Carbon Dioxide",0.03
					},
				}
			};
			return View(data);
		}
        #endregion

        #region TimeSeriesChart
        public async Task<IActionResult> TimeSeriesChart()
		{
			var data = new KKTimeSeriesChartModel()
			{
				Title = "USD to EUR exchange rate over time",
				TitleX = "",
				TitleY = "Exchange rate'",
				Data = { }
			};
			using (HttpClient client = new HttpClient())
			{
				try
				{
					HttpResponseMessage response = await client.GetAsync("https://cdn.jsdelivr.net/gh/highcharts/highcharts@v10.3.3/samples/data/usdeur.json");
					response.EnsureSuccessStatusCode();
					string responseBody = await response.Content.ReadAsStringAsync();
					dynamic jsonData = JsonConvert.DeserializeObject(responseBody);
					// Here, you can parse the JSON response as needed

					data.Data = jsonData;

				}
				catch (HttpRequestException e)
				{
					Console.WriteLine($"HttpRequestException: {e.Message}");
				}
			}
			return View(data);
		}
        #endregion

        #region Basic Area Chart
        public IActionResult BasicAreaChart()
        {
            var model = new BasicArea
            {
                ChartTitle = "US and USSR Nuclear Stockpiles",
                Description = "Image description: An area chart compares the nuclear stockpiles of the USA and the USSR/Russia between 1945 and 2017...",
                Source = "FAS",
                RangeDescription = "Range: 1940 to 2017.",
                YAxisTitle = "Nuclear weapon states",
                PointStart = 1940,
                UsaData = new int[] {  0, 0, 0, 0, 0, 2, 9, 13, 50, 170, 299, 438, 841,
            1169, 1703, 2422, 3692, 5543, 7345, 12298, 18638, 22229, 25540,
            28133, 29463, 31139, 31175, 31255, 29561, 27552, 26008, 25830,
            26516, 27835, 28537, 27519, 25914, 25542, 24418, 24138, 24104,
            23208, 22886, 23305, 23459, 23368, 23317, 23575, 23205, 22217,
            21392, 19008, 13708, 11511, 10979, 10904, 11011, 10903, 10732,
            10685, 10577, 10526, 10457, 10027, 8570, 8360, 7853, 5709, 5273,
            5113, 5066, 4897, 4881, 4804, 4717, 4571, 4018, 3822, 3785, 3805,
            3750, 3708, 3708 },
                UssrRussiaData = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0,
            1, 5, 25, 50, 120, 150, 200, 426, 660, 863, 1048, 1627, 2492,
            3346, 4259, 5242, 6144, 7091, 8400, 9490, 10671, 11736, 13279,
            14600, 15878, 17286, 19235, 22165, 24281, 26169, 28258, 30665,
            32146, 33486, 35130, 36825, 38582, 40159, 38107, 36538, 35078,
            32980, 29154, 26734, 24403, 21339, 18179, 15942, 15442, 14368,
            13188, 12188, 11152, 10114, 9076, 8038, 7000, 6643, 6286, 5929,
            5527, 5215, 4858, 4750, 4650, 4600, 4500, 4490, 4300, 4350, 4330,
            4310, 4495, 4477 }
            };

            return View(model);
        }
        #endregion

        #region StackedBarChart
        public IActionResult StackedGroupColumn()
        {

            var model = new StackedGroupColumn
            {
                ChartTitle = "Olympic Games all-time medal table, grouped by continent",
                XAxisCategories = new List<string> { "Gold", "Silver", "Bronze" },
                Description = "Chart showing stacked columns with grouping, allowing specific series to be stacked on the same column. Stacking is often used to visualize data that accumulates to a sum.",
                Series = new List<MedalSeries>
                {
                    new() { Name = "Norway", Data = new List<int> { 148, 133, 124 }, Stack = "Europe" },
                    new() { Name = "Germany", Data = new List<int> { 102, 98, 65 }, Stack = "Europe" },
                    new() { Name = "United States", Data = new List<int> { 113, 122, 95 }, Stack = "North America" },
                    new() { Name = "Canada", Data = new List<int> { 77, 72, 80 }, Stack = "North America" }
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
    }
}









