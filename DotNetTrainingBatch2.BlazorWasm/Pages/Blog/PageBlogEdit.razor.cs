using DotNetTrainingBatch2.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Newtonsoft.Json;
using System.Net.Mime;
using System.Text;

namespace DotNetTrainingBatch2.BlazorWasm.Pages.Blog
{
    public partial class PageBlogEdit
    {
        [Parameter]
        public int id { get; set; }

        private BlogDataModel item;

        protected override async Task OnInitializedAsync()
        {
            var result = await HttpClient.GetAsync("api/blog/" + id);
            if (result.IsSuccessStatusCode)
            {
                string jsonStr = await result.Content.ReadAsStringAsync();
                item = JsonConvert.DeserializeObject<BlogDataModel>(jsonStr)!;
            }
        }
        public async Task Update(int id)
        {
            string jsonStr = JsonConvert.SerializeObject(item);
            HttpContent content = new StringContent(jsonStr, Encoding.UTF8, MediaTypeNames.Application.Json);
            var result = await HttpClient.PutAsync($"api/blog/{id}", content);
            if (result.IsSuccessStatusCode)
            {
                var message = await result.Content.ReadAsStringAsync();
                Snackbar.Add(message, Severity.Success);
                Nav.NavigateTo("setup/blog");
            }
            else
            {
                var message = await result.Content.ReadAsStringAsync();
                Snackbar.Add(message, Severity.Error);
                Nav.NavigateTo("setup/blog");
            }
        }
    }
}
