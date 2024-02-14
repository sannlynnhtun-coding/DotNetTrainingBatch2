using Microsoft.AspNetCore.Mvc;
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
        public List<string>? Labels { get; set; }

        public List<int> Bdata { get; set; }

        public List<int> Ldata { get; set; }
    }

    public class RadarChartModel
    {
        public List<string>? Labeldata { get; set; }
        public List<string>? DataSetName { get; set; }
        public List<int>? DataSetData1 { get; set; }
        public List<int>? DataSetData2 { get; set; }
    }
    public class ChartJSLineChartModel
    {
        public List<string>? Labeldata { get; set; }
        public List<string>? DataSetName { get; set; }
        public List<int>? DataSetData { get; set; }

    }

    #region Doughnut
    public class Doughnut
    {
        public string Label { get; set; }
        public List<string> BackgroundColor { get; set; }
        public List<int> Data { get; set; }
    }

    #endregion


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

    public class AudioBoxplotChartModel
    {
        public List<string>? Title { get; set; }
        public List<string>? Subtitle { get; set; }
    }
    public class BulletGraphChartModel
    {
        public List<string>? Title { get; set; }
    }

    #region BasicArea
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
    #endregion


    #region Stacked and GroupColumn Chart
    public class StackedGroupColumn
    {
        public string ChartTitle { get; set; }
        public List<string> XAxisCategories { get; set; }
        public List<MedalSeries> Series { get; set; }
        public string Description { get; set; }
    }

    public class MedalSeries
    {
        public string Name { get; set; }
        public List<int> Data { get; set; }
        public string Stack { get; set; }
    }
    #endregion

    #endregion

    #region CanvasJs
    //BarChart
    public class DataPoint
    {
        public int Y { get; set; }

        public string Label { get; set; }

    }
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
    public class CanvasBarChartModel
    {
        public List<DataPoint> DataPoints { get; set; }
    }

    public class FinalcialChartModel
    {
        public List<string>? Title { get; set; }
        public List<string>? Subtitles { get; set; }
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

    #region AreaChart

    public class AreaChart
    {
        public string Title { get; set; }
        public List<AreDataPoint> AreaDataPoint { get; set; }
    }

    public class AreDataPoint
    {
        public DateOnly X { get; set; }
        public double Y { get; set; }
        public string Label { get; set; }
        public string IndexLabel { get; set; }
        public string MarkerColor { get; set; }
    }

    #endregion


    #region 100StackedBaChart
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
        #endregion

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
    #region
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
    #endregion
    #region SplineWithInvertedAxes Chart
    public class SplineWithInvertedAxesChartModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public List<SeriesData> Series { get; set; }
    }

    public class SeriesData
    {
        public string Name { get; set; }
        public List<PointData> Data { get; set; }
    }

    public class PointData
    {
        public int X { get; set; }
        public double Y { get; set; }
    }


    #endregion

    #region LogarithmicAxisChartModel
    public class LogarithmicAxisChartModel
    {
        public List<int> Data { get; set; }
        public int PointStart { get; set; }
        public string Title { get; set; }
    }
    #endregion
    #region BubbleChartModel
    public class JSBubbleChartModel
    {
        public string Label { get; set; }
        public List<JSBubbleChartData> Data { get; set; }
        public string BackgroundColor { get; set; }
    }

    public class JSBubbleChartData
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
    }

    #endregion

    #region BarChart
    public class BarChartJSModel
    {
        public int[] Data { get; set; }
        public string[] Labels { get; set; }
    }
    #endregion

    #region Range Area Chart
    public class RangeAreaChartModel
    {
        public List<RangeAreaChartModel> DataPoints { get; set; }
        public int YMin { get; set; }
        public int YMax { get; set; }
        public DateTime X { get; set; }

    }
    #endregion

    #region Range Spline Area Chart
    public class RangeSplineAreaChartModel
    {
        public List<RangeSplineAreaChartModel> DataPoints { get; set; }
        public int YMin { get; set; }
        public int YMax { get; set; }
        public DateTime X { get; set; }

    }
    #endregion
}
