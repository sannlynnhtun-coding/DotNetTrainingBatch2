namespace AKLMPSTYZDotNetCore.MvcApp.Models;

public class StackedAreaChartModel
{
    public List<string>? Title { get; set; }
    public List<string>? AxisXtitle { get; set; }
    #region datapoint
    public List<DataPoints>? IOSDataPoints { get; set; }
    public List<DataPoints>? AndroidDataPoint { get; set; }
    public class DataPoints
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    #endregion
}