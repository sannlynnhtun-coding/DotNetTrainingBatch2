namespace AKLMPSTYZDotNetCore.MvcApp.Models;

public class AreDataPoint
{
    public DateOnly X { get; set; }
    public double Y { get; set; }
    public string Label { get; set; }
    public string IndexLabel { get; set; }
    public string MarkerColor { get; set; }
}