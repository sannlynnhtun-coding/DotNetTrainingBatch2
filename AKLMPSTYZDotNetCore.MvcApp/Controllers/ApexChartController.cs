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
    }
}
