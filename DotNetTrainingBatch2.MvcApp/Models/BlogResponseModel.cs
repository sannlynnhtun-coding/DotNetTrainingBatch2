namespace DotNetTrainingBatch2.MvcApp.Models;

public class BlogResponseModel
{
    public PageSettingModel PageSetting { get; set; }
    public List<BlogDataModel> Data { get; set; }
}