using AKLMPSTYZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
