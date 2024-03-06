using DotNetTrainingBatch2.BlazorWasm.Shared;
using DotNetTrainingBatch2.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Newtonsoft.Json;
using static MudBlazor.CategoryTypes;

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

        private async Task List(int pageNo, int pageSize = 10)
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

        private async Task PageChanged(int i)
        {
            _pageNo = i;
            await List(_pageNo);
        }

        private async Task Delete(int id)
        {
            var parameters = new DialogParameters<ConfirmDialog>();
            parameters.Add(x => x.Message,
                "Are you sure want to delete?");

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            var dialog = await DialogService.ShowAsync<ConfirmDialog>("Confirm", parameters, options);
            var result = await dialog.Result;
            if (result.Canceled) return;

            // logic
            //DeleteBlog();
        }
    }
}
