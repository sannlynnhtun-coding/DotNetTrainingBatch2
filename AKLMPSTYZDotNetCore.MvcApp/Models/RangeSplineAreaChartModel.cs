namespace AKLMPSTYZDotNetCore.MvcApp.Models;

public class RangeSplineAreaChartModel
{
    public List<RangeSplineAreaChartModel> DataPoints { get; set; }
    public int YMin { get; set; }
    public int YMax { get; set; }
    public DateTime X { get; set; }

}