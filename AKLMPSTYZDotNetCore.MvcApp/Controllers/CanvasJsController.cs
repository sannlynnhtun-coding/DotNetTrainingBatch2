using AKLMPSTYZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using static AKLMPSTYZDotNetCore.MvcApp.Models.KKChartsModel;
using static AKLMPSTYZDotNetCore.MvcApp.Models.StackedAreaChartModel;

using static AKLMPSTYZDotNetCore.MvcApp.Models.StackedBarChart;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AKLMPSTYZDotNetCore.MvcApp.Controllers
{
	public class CanvasJsController : Controller
	{
		public IActionResult PieChart()
		{
			return View();
		}

		public IActionResult BarChart()
		{
			var model = new CanvasBarChartModel
			{
				DataPoints = new List<DataPoint>
				{
					new DataPoint { Y = 3, Label = "Sweden" },
					new DataPoint { Y = 7, Label = "Taiwan" },
					new DataPoint { Y = 5, Label = "Russia" },
					new DataPoint { Y = 9, Label = "Spain" },
					new DataPoint { Y = 7, Label = "Brazil" },
					new DataPoint { Y = 7, Label = "India" },
					new DataPoint { Y = 9, Label = "Italy" },
					new DataPoint { Y = 8, Label = "Australia" },
					new DataPoint { Y = 11, Label = "Canada" },
					new DataPoint { Y = 15, Label = "South Korea" },
					new DataPoint { Y = 12, Label = "Netherlands" },
					new DataPoint { Y = 15, Label = "Switzerland" },
					new DataPoint { Y = 25, Label = "Britain" },
					new DataPoint { Y = 28, Label = "Germany" },
					new DataPoint { Y = 29, Label = "France" },
					new DataPoint { Y = 52, Label = "Japan" },
					new DataPoint { Y = 103, Label = "China" },
					new DataPoint { Y = 134, Label = "US" }
				}
			};
			return View(model);
		}

		public IActionResult SplineChart()
		{
			var model = new SplineChartModel
			{
				SpdataPoints = new List<SpdataPoint>
				{
					new SpdataPoint { X = new DateTime(2002, 1, 1), Y = 2506000 },
					new SpdataPoint { X = new DateTime(2003, 1, 1), Y = 2798000 },
					new SpdataPoint { X = new DateTime(2004, 1, 1), Y = 3386000 },
					new SpdataPoint { X = new DateTime(2005, 1, 1), Y = 6944000 },
					new SpdataPoint { X = new DateTime(2006, 1, 1), Y = 6026000 },
					new SpdataPoint { X = new DateTime(2007, 1, 1), Y = 2394000 },
					new SpdataPoint { X = new DateTime(2008, 1, 1), Y = 1872000 },
					new SpdataPoint { X = new DateTime(2009, 1, 1), Y = 2140000 },
					new SpdataPoint { X = new DateTime(2010, 1, 1), Y = 7289000 },
					new SpdataPoint { X = new DateTime(2011, 1, 1), Y = 4830000 },
					new SpdataPoint { X = new DateTime(2012, 1, 1), Y = 2009000 },
					new SpdataPoint { X = new DateTime(2013, 1, 1), Y = 2840000 },
					new SpdataPoint { X = new DateTime(2014, 1, 1), Y = 2396000 },
					new SpdataPoint { X = new DateTime(2015, 1, 1), Y = 1613000 },
					new SpdataPoint { X = new DateTime(2016, 1, 1), Y = 2821000 },
					new SpdataPoint { X = new DateTime(2017, 1, 1), Y = 2000000 },
				}
			};
			return View(model);
		}

		#region Step Area Chart
		public IActionResult StepAreaChart()
		{
			var model = new StepAreaChartModel()
			{
				DataPoints = new List<StepAreaChartDataPointsModel>
				{
					new StepAreaChartDataPointsModel { X = new DateTime(2002, 1, 1), Y = 34},
					new StepAreaChartDataPointsModel { X = new DateTime(2003, 1, 1), Y = 73},
					new StepAreaChartDataPointsModel { X = new DateTime(2004, 1, 1), Y = 78},
					new StepAreaChartDataPointsModel { X = new DateTime(2005, 1, 1), Y = 82},
					new StepAreaChartDataPointsModel { X = new DateTime(2006, 1, 1), Y = 70},
				}
			};
			return View(model);
		}
		#endregion

		#region Column Chart
		public IActionResult ColumnChart()
		{
			var model = new ColumChartModel()
			{
				DataPoints = new List<ColumnChartDataPointsModel>
				{
					new ColumnChartDataPointsModel { Y = 266455, Label = "Venezuela" },
					new ColumnChartDataPointsModel { Y = 266455, Label = "Saudi" },
					new ColumnChartDataPointsModel { Y = 169709, Label = "Canada" },
					new ColumnChartDataPointsModel { Y = 158400, Label = "Iran" },
					new ColumnChartDataPointsModel { Y = 142503, Label = "Iraq" },
					new ColumnChartDataPointsModel { Y = 101500, Label = "Kuwait" },
					new ColumnChartDataPointsModel { Y = 97800, Label = "UAE" },
					new ColumnChartDataPointsModel { Y = 80000, Label = "Russia" },
				}
			};
			return View(model);
		}
		#endregion

		public IActionResult FinalcialChart()
		{
			var model = new FinalcialChartModel()
			{
				Title = new List<string> { "Netflix Stock Price in 2016" },
				Subtitles = new List<string> { "Weekly Averages" },
			};
			return View(model);
		}
		public IActionResult StackedAreaCharts()
		{
			var model = new StackedAreaChartModel()
			{
				Title = new List<string> { "Cumulative App Downloads on iTunes and Play Store" },
				AxisXtitle = new List<string> { "Months After Launch" },
				IOSDataPoints = new List<DataPoints>
					{
						new DataPoints { x = 1, y = 3000 },
						new DataPoints { x = 2, y = 7000 },
						new DataPoints { x = 3, y = 10000 },
						new DataPoints { x = 4, y = 14000 },
						new DataPoints { x = 5, y = 23000 },
						new DataPoints { x = 6, y = 31000 },
						new DataPoints { x = 7, y = 42000 },
						new DataPoints { x = 8, y = 56000 },
						new DataPoints { x = 9, y = 64000 },
						new DataPoints { x = 10, y = 81000 },
						new DataPoints { x = 11, y = 105000 }
					},
				AndroidDataPoint = new List<DataPoints>
					{
					new DataPoints { x = 4, y = 4000 },
					new DataPoints { x = 5, y = 6000 },
					new DataPoints { x = 6, y = 9000 },
					new DataPoints { x = 7, y = 14000 },
					new DataPoints { x = 8, y = 21000 },
					new DataPoints { x = 9, y = 31000 },
					new DataPoints { x = 10, y = 46000 },
					new DataPoints { x = 11, y = 61000 }
					}
			};

			return View(model);
        }

        #region PyramidChart
        public IActionResult PyramidChart()
        {
            var data = new KKPyramidModel()
            {
                Title = "OKNRSR",
                DataPoints = new List<KKDataPointsModel>()
                {
                    new KKDataPointsModel()
                    {
                        y=26.66,
                        label="Sleep"
                    },new KKDataPointsModel()
                    {
                        y=16,
                        label="Eat"
                    },new KKDataPointsModel()
                    {
                        y=57.34,
                        label="Code"
                    }
                }
            };
            return View(data);
        }
        #endregion

        #region RangeArea
        public IActionResult RangeArea()
        {
            var data = new KKRangeAreaModel()
            {
                Title = "Temperature in Toronto - Jan 2024",
                TitleY = "Temperature (°C)",
                SuffixY = "°C",
                TitleX = "",
                DataPoints = new List<KKRangeAreaDataPoint>() {
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 01), y = new List<int>() { 15, 21 } },
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 02), y = new List<int>() { 13, 27 } },
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 03), y = new List<int>() { 14, 23 } },
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 04), y = new List<int>() { 17, 25 } },
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 05), y = new List<int>() { 16, 23 } },
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 06), y = new List<int>() { 16, 29 } },
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 07), y = new List<int>() { 18, 27 } },
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 08), y = new List<int>() { 16, 25 } },
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 09), y = new List<int>() { 15, 25 } },
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 10), y = new List<int>() { 16, 23 } },
                    new KKRangeAreaDataPoint() { x = new DateTime(2024, 01, 11), y = new List<int>() { 15, 26 } }
                }

            };
            return View(data);
        }
        #endregion

        #region AreaChart
        public IActionResult AreaChart()
		{
			var model = new AreaChart()
			{
				Title = "Number of iPhones Sold in Different Quarters",
				AreaDataPoint = new List<AreDataPoint>
		{
			new AreDataPoint { X = new DateOnly(2015, 02, 1), Y = 74.4, Label = "Q1-2015" },
			new AreDataPoint { X = new DateOnly(2015, 05, 1), Y = 61.1, Label = "Q2-2015" },
			new AreDataPoint { X = new DateOnly(2015, 08, 1), Y = 47.0, Label = "Q3-2015" },
			new AreDataPoint { X = new DateOnly(2015, 11, 1), Y = 48.0, Label = "Q4-2015" },
			new AreDataPoint { X = new DateOnly(2016, 02, 1), Y = 74.8, Label = "Q1-2016" },
			new AreDataPoint { X = new DateOnly(2016, 05, 1), Y = 51.1, Label = "Q2-2016" },
			new AreDataPoint { X = new DateOnly(2016, 08, 1), Y = 40.4, Label = "Q3-2016" },
			new AreDataPoint { X = new DateOnly(2016, 11, 1), Y = 45.5, Label = "Q4-2016" },
			new AreDataPoint { X = new DateOnly(2017, 02, 1), Y = 78.3, Label = "Q1-2017", IndexLabel = "Highest", MarkerColor = "red" }
		}
			};

			return View(model);
		}
		#endregion

		#region StackedBarChart

		public IActionResult StackedBarChart()
		{
			var model = new StackedBarChart
			{
				Title = "Division of Products Sold in 2nd Quarter",
				Months = new List<MonthData>
			{
                new MonthData
                {
                    Name = "April",
                    StackedDataPoints = new List<StackedDataPoint>
                    {
                        new StackedDataPoint { Y = 600, Label = "Water Filter" },
                        new StackedDataPoint { Y = 400, Label = "Modern Chair" },
                        new StackedDataPoint { Y = 120, Label = "VOIP Phone" },
                        new StackedDataPoint { Y = 250, Label = "Microwave" },
                        new StackedDataPoint { Y = 120, Label = "Water Filter" },
                        new StackedDataPoint { Y = 374, Label = "Expresso Machine" },
                        new StackedDataPoint { Y = 350, Label = "Lobby Chair" }
                    }
                },
                new MonthData
                {
                    Name = "May",
                    StackedDataPoints = new List<StackedDataPoint>
                    {
                        new StackedDataPoint { Y = 400, Label = "Water Filter" },
                        new StackedDataPoint { Y = 500, Label = "Modern Chair" },
                        new StackedDataPoint { Y = 220, Label = "VOIP Phone" },
                        new StackedDataPoint { Y = 350, Label = "Microwave" },
                        new StackedDataPoint { Y = 220, Label = "Water Filter" },
                        new StackedDataPoint { Y = 474, Label = "Expresso Machine" },
                        new StackedDataPoint { Y = 450, Label = "Lobby Chair" }
                    }
                },
                new MonthData
                {
                    Name = "June",
                    StackedDataPoints = new List<StackedDataPoint>
                    {
                        new StackedDataPoint { Y = 300, Label = "Water Filter" },
                        new StackedDataPoint { Y = 610, Label = "Modern Chair" },
                        new StackedDataPoint { Y = 215, Label = "VOIP Phone" },
                        new StackedDataPoint { Y = 221, Label = "Microwave" },
                        new StackedDataPoint { Y = 75, Label = "Water Filter" },
                        new StackedDataPoint { Y = 310, Label = "Expresso Machine" },
                        new StackedDataPoint { Y = 340, Label = "Lobby Chair" }
                    }
                }
            }
            };

            return View(model);
        }
        #endregion

        #region Range Area Chart
        public IActionResult RangeAreaChart()
        {
            var model = new RangeAreaChartModel()
            {
                DataPoints = new List<RangeAreaChartModel>
                {
            new RangeAreaChartModel { X = new DateTime(2017, 06, 01), YMin = 15, YMax = 21 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 02), YMin = 13, YMax = 27 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 03), YMin = 14, YMax = 23 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 04), YMin = 17, YMax = 25 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 05), YMin = 16, YMax = 23 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 06), YMin = 16, YMax = 29 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 07), YMin = 18, YMax = 27 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 08), YMin = 16, YMax = 25 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 09), YMin = 15, YMax = 25 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 10), YMin = 16, YMax = 23 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 11), YMin = 15, YMax = 26 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 12), YMin = 19, YMax = 23 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 13), YMin = 16, YMax = 19 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 14), YMin = 16, YMax = 27 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 15), YMin = 18, YMax = 27 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 16), YMin = 17, YMax = 24 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 17), YMin = 19, YMax = 23 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 18), YMin = 19, YMax = 26 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 19), YMin = 20, YMax = 30 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 20), YMin = 17, YMax = 21 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 21), YMin = 19, YMax = 30 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 22), YMin = 21, YMax = 23 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 23), YMin = 20, YMax = 24 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 24), YMin = 17, YMax = 22 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 25), YMin = 17, YMax = 22 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 26), YMin = 16, YMax = 22 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 27), YMin = 19, YMax = 26 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 28), YMin = 18, YMax = 23 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 29), YMin = 18, YMax = 27 },
            new RangeAreaChartModel { X = new DateTime(2017, 06, 30), YMin = 20, YMax = 31 }
                }
            };
            return View(model);
        }
        #endregion

        #region Range Spline Area Chart
        public IActionResult RangeSplineAreaChart()
        {
            var model = new RangeSplineAreaChartModel()
            {
                DataPoints = new List<RangeSplineAreaChartModel>
                {
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 1, 01), YMin = 7, YMax = 18 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 2, 01), YMin = 11, YMax = 23 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 3, 01), YMin = 15, YMax = 28 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 4, 01), YMin = 22, YMax = 36 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 5, 01), YMin = 26, YMax = 39 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 6, 01), YMin = 27, YMax = 37 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 7, 01), YMin = 27, YMax = 34 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 8, 01), YMin = 26, YMax = 33 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 9, 01), YMin = 24, YMax = 33 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 10, 01), YMin = 19, YMax = 31 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 11, 01), YMin = 13, YMax = 27 },
                  new RangeSplineAreaChartModel { X = new DateTime(2016, 12, 01), YMin = 8, YMax = 21 }
                }
            };
            return View(model);
        }
        #endregion
    }
}
