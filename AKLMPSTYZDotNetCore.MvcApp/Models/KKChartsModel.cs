namespace AKLMPSTYZDotNetCore.MvcApp.Models;

public class KKChartsModel
{
    public class KKPieChartModel
    {
        public List<int> Series { get; set; }
        public List<string> Lables { get; set; }
    }

    public class KKRadarSeriseModel
    {
        public string name { get; set; }
        public List<int> data { get; set; }

    }
    public class KKRadarChartModel
    {
        public List<KKRadarSeriseModel> Series { get; set; }
        public List<string> Categories { get; set; }
    }

    public class KKScatterDotPosition
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    public class KKScatterChartModel
    {
        public List<KKScatterDotPosition> data1 { get; set; }
        public List<KKScatterDotPosition> data2 { get; set; }
    }
    public class KKHoriBarDataSetModel
    {
        public string label { get; set; }
        public List<int> data { get; set; }
        public string borderColor { get; set; }
        public string backgroundColor { get; set; }

    }
    public class KKHoriBarModel
    {
        public List<string> labels { get; set; }
        public List<KKHoriBarDataSetModel> datasets { get; set; }
    }

    public class KKSemiCircleModel
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public List<List<object>> Data { get; set; }

    }

    public class KKDataPointsModel
    {
        public string label { get; set; }
        public double y { get; set; }
    }

    public class KKPyramidModel
    {
        public string Title { get; set; }
        public List<KKDataPointsModel> DataPoints { get; set; }
    }

    public class KKRangeAreaDataPoint
    {
        public List<int> y { get; set; }
        public DateTime x { get; set; }
    }

    public class KKRangeAreaModel
    {
        public string Title { get; set; }
        public string TitleY { get; set; }
        public string SuffixY { get; set; }
        public string TitleX { get; set; }
        public List<KKRangeAreaDataPoint> DataPoints { get; set; }
    }

    public class KKTimeSeriesChartModel
    {
        public string Title { get; set; }
        public string TitleX { get; set; }
        public string TitleY { get; set; }
        public dynamic Data { get; set; }

    }
}