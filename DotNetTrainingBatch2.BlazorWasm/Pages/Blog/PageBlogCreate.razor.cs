using System.Net.Mime;
using System.Text;
using DotNetTrainingBatch2.Models;
using Microsoft.JSInterop;
using MudBlazor;
using Newtonsoft.Json;

namespace DotNetTrainingBatch2.BlazorWasm.Pages.Blog
{
    public partial class PageBlogCreate
    {
        private BlogDataModel requestModel = new();

        private async Task Save()
        {
            var blogJson = JsonConvert.SerializeObject(requestModel);
            HttpContent content = new StringContent(blogJson, Encoding.UTF8, MediaTypeNames.Application.Json);
            var response = await HttpClient.PostAsync("api/Blog", content);
            if (response.IsSuccessStatusCode)
            {
                 var message = await response.Content.ReadAsStringAsync();
                //await JsRuntime.InvokeVoidAsync("alert", message);
                Snackbar.Add(message, Severity.Success);
                Nav.NavigateTo("/setup/blog");
            }
        }
    }
}
