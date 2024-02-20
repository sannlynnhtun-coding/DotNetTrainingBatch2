namespace DotNetTrainingBatch2.MvcApp.Models;

public class BasicArea
{
    public string ChartTitle { get; set; }
    public string Description { get; set; }
    public string Source { get; set; }
    public string RangeDescription { get; set; }
    public string YAxisTitle { get; set; }
    public int PointStart { get; set; }
    public int[] UsaData { get; set; }
    public int[] UssrRussiaData { get; set; }
}