namespace DotNetTrainingBatch2.MvcApp.Models;

public class StackedGroupColumn
{
    public string ChartTitle { get; set; }
    public List<string> XAxisCategories { get; set; }
    public List<MedalSeries> Series { get; set; }
    public string Description { get; set; }
}