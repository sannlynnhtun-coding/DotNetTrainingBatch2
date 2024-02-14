namespace AKLMPSTYZDotNetCore.MvcApp.Models;

public class StackedBarChart
{
    public string Title { get; set; }
    public List<MonthData> Months { get; set; }

    public class MonthData
    {
        public string Name { get; set; }
        public List<StackedDataPoint> StackedDataPoints { get; set; }
    }

    public class StackedDataPoint
    {
        public int Y { get; set; }
        public string Label { get; set; }
    }
}