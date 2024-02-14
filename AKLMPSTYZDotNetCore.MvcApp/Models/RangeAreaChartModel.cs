namespace AKLMPSTYZDotNetCore.MvcApp.Models;

public class RangeAreaChartModel
{
    public List<RangeAreaChartModel> DataPoints { get; set; }
    public int YMin { get; set; }
    public int YMax { get; set; }
    public DateTime X { get; set; }

}