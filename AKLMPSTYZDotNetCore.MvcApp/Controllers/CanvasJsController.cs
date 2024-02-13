using AKLMPSTYZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using static AKLMPSTYZDotNetCore.MvcApp.Models.StackedAreaChartModel;
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
	}
}
