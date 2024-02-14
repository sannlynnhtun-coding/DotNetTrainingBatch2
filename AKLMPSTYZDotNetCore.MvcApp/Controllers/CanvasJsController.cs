using AKLMPSTYZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
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
            #endregion
        }
	}
}
