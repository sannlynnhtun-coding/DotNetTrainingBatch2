namespace DotNetTrainingBatch2.MvcApp.Models;

public class PageSettingModel
{
    public PageSettingModel() { }

    public PageSettingModel(int pageNo, int pageSize, int pageCount, int pageRowCount)
    {
        PageNo = pageNo;
        PageSize = pageSize;
        PageCount = pageCount;
        PageRowCount = pageRowCount;
    }
    public int PageNo { get; set; }
    public int PageSize { get; set; }
    public int PageCount { get; set; }
    public int PageRowCount { get; set; }
}