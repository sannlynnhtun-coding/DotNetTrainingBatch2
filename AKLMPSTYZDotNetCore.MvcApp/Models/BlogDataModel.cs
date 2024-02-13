using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AKLMPSTYZDotNetCore.MvcApp.Models
{
    [Table("Tbl_Blog")]
    public class BlogDataModel
    {
        [Key]
        public int Blog_Id { get; set; }
        public string? Blog_Title { get; set; }
        public string? Blog_Author { get; set; }
        public string? Blog_Content { get; set; }
    }

    public class PieChartModel
    {
        public List<int> Series { get; set; }
        public List<string> Lables { get; set; }
    }
    public class BarChartModel
    {
        public List<int> Series { get; set; }
        public List<string> Lables { get; set; }
    }
    public class LineChartModel
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
        public List<string> Categories { get; set; }
    }
    public class MixedChart
    {
        public List<double> Income_colum_data { get; set; }
        public List<double> Cashflow_column_data { get; set; }
        public List<int> Xaxis_categories { get; set; }
        public List<int> Revenue_line { get; set; }
    }
    public class PyramidChartModel
    {
        public List<string> categories { get; set; }
        public List<int> data { get; set; }
    }
    #region 3DbubbleChart
    public class BubbleChartModel
    {
        public List<BubbleSeries> Series { get; set; }
    }

    public class BubbleSeries
    {
        public string Name { get; set; }
        public List<BubbleData> Data { get; set; }
    }

    public class BubbleData
    {
        public DateTime X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
    #endregion

    #region PolarAreaChart
    public class PolarAreaChartModel
    {
        public List<int> Series { get; set; }
    }
    #endregion

    //ScatterChart
    public class Data
    {
        public double X { get; set; }

        public double Y { get; set; }
    }

    public class ScatterChartModel
    {
        public List<Data> Datas { get; set; }
    }

    //MixedChart
    public class MixedChartModel
    {
        public List<string> Labels { get; set; }

        public List<int> Bdata { get; set; }

        public List<int> Ldata { get; set; }
    }

    #region HighCharts
    public class WithDataLabelsChartModel
    {
        public List<string> Categories { get; set; }

        public List<double> RegData { get; set; }

        public List<double> TalData { get; set; }
    }

    public class RadialBarChartModel
    {
        public List<string> Categories { get; set; }

        public List<int> Gdata { get; set; }

        public List<int> Sdata { get; set; }

        public List<int> Bdata { get; set; }
    }

    #endregion

    #region CanvasJs
    //BarChart
    public class DataPoint
    {
        public int Y { get; set; }

        public string Label { get; set; }

    }

    public class CanvasBarChartModel
    {
        public List<DataPoint> DataPoints { get; set; }
    }

    //SplineChart
    public class SpdataPoint
    {
        public DateTime X { get; set; }

        public Double Y { get; set; }
    }

    public class SplineChartModel
    {
        public List<SpdataPoint> SpdataPoints { get; set; }
    }
    #endregion

    #region Basic Bar Chart
    public class BasicBarChartModel
    {
        public List<BasicBarChartDataSeriesModel> Series { get; set; }
    }

    public class BasicBarChartDataSeriesModel
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
    }
    #endregion

    #region Percentage Area Chart
    public class PercentageAreaChartModel
    {
        public List<PercentageAreaChartSeriesModel> Series { get; set; }
    }
    public class PercentageAreaChartSeriesModel
    {
        public string name { get; set; }
        public List<double> data { get; set; }
    }
    #endregion

    #region StepAreaChart
    public class StepAreaChartModel
    {
        public List<StepAreaChartDataPointsModel> DataPoints { get; set; }
    }
    public class StepAreaChartDataPointsModel
    {
        public DateTime X { get; set; }

        public Double Y { get; set; }
    }
    #endregion

    #region ColumnChart
    public class ColumnChartDataPointsModel
    {
        public int Y { get; set; }
        public string Label { get; set; }
    }
    public class ColumChartModel
    {
        public List<ColumnChartDataPointsModel> DataPoints { get; set; }
    }
    #endregion
}
