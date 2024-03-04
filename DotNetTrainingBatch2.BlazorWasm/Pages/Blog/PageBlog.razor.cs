using DotNetTrainingBatch2.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace DotNetTrainingBatch2.BlazorWasm.Pages.Blog
{
    public partial class PageBlog
    {
        //[Inject]
        //public HttpClient HttpClient2 { get; set; }
        private int _pageNo = 1;
        private int _pageSize = 10;

        private BlogListResponseModel? Model;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await List(_pageNo, _pageSize);
            }
        }

        private async Task List(int pageNo, int pageSize)
        {
            _pageNo = pageNo;
            _pageSize = pageSize;
            var result = await HttpClient.GetAsync($"api/Blog/{pageNo}/{pageSize}");
            if (result.IsSuccessStatusCode)
            {
                var jsonStr = await result.Content.ReadAsStringAsync();
                Model = JsonConvert.DeserializeObject<BlogListResponseModel>(jsonStr)!;
                StateHasChanged();
            }
        }
    }
}
