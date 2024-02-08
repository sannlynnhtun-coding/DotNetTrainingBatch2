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
}
