using AKLMPSTYZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace AKLMPSTYZDotNetCore.MvcApp.Controllers
{
    public class BlogHttpClientController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly RestClient _restClient;
        private readonly IBlogApi _blogApi;
        private readonly IConfiguration _configuration;

        public BlogHttpClientController(HttpClient httpClient, IConfiguration configuration, RestClient restClient, IBlogApi blogApi)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _restClient = restClient;
            _blogApi = blogApi;
        }

        public async Task<IActionResult> Index()
        {
            var lst = new List<BlogDataModel>();
            //string url = $"{_configuration.GetSection("ApiUrl")}/api/Blog";
            //var response = await _httpClient.GetAsync("api/Blog");
            //if (response.IsSuccessStatusCode)
            //{
            //    string jsonStr = await response.Content.ReadAsStringAsync();
            //    lst = JsonConvert.DeserializeObject<List<BlogDataModel>>(jsonStr)!;
            //}

            //RestRequest restRequest = new RestRequest("api/Blog", Method.Get);
            //var response = await _restClient.ExecuteAsync(restRequest);
            //if (response.IsSuccessStatusCode)
            //{
            //    string jsonStr = response.Content!;
            //    lst = JsonConvert.DeserializeObject<List<BlogDataModel>>(jsonStr)!;
            //}

            lst = await _blogApi.GetBlogs();
            return View(lst);
        }
    }
}
