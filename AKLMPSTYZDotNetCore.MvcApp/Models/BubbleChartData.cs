namespace AKLMPSTYZDotNetCore.MvcApp.Models;

public class BubbleChartData
{
    public List<BubbleDataSet> DataSets { get; set; }

    public class BubbleDataSet
    {
        public string Label { get; set; }
        public List<BubbleDataPoint> DataPoints { get; set; }
    }

    public class BubbleDataPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
    }
}