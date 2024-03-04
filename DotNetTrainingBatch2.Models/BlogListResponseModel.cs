namespace DotNetTrainingBatch2.Models
{
    public class BlogListResponseModel
    {
        public bool IsEndOfPage { get; set; }
        public int PageCount { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public List<BlogDataModel> Data { get; set; }
    }
}
