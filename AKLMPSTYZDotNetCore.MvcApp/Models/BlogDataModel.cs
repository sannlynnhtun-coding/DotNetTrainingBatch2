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
}
