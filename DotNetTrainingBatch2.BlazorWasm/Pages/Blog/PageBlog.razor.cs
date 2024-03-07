using DotNetTrainingBatch2.BlazorWasm.Shared;
using DotNetTrainingBatch2.Models;
using MudBlazor;
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

        private void Edit(int id)
        {
            Nav.NavigateTo($"setup/blog/edit/{id}");
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
            var responce = await HttpClient.DeleteAsync($"api/Blog/{id}");
            if (responce.IsSuccessStatusCode)
            {
                await List(_pageNo, _pageSize);
                Snackbar.Add("Blog deleted successfully", Severity.Success);
            }
            else
            {
                Snackbar.Add("Failed to delete the blog. Please try again.", Severity.Error);
            }
        }
    }
}
