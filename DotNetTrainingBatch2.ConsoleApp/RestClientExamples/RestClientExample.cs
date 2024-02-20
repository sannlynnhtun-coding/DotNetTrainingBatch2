using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetTrainingBatch2.ConsoleApp.Models;

namespace DotNetTrainingBatch2.ConsoleApp.RestClientExamples
{
    public class RestClientExample
    {
        private string _blogEndpoint = "https://localhost:7185/api/blog";
        public async Task Run()
        {
            // get
            // post
            // put
            // patch
            // delete

            // task - 1 = 10
            // task - 2 = 10
            // task - 3 = 10 (1, 3)

            // 30
            // 10

            // 20

            //await Read();
            //await Edit(13);
            //await Edit(1002);
            await Create("Test Title", "Test Author", "Test Content");
            //await Update(6, "New tg Title", "New tg Author", "New tg Content");
            await Delete(7);

        }

        public async Task Read()
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest(_blogEndpoint, Method.Get);    
            //await client.GetAsync(request);
            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string jsonStr = response.Content!;
                List<BlogDataModel> lst = JsonConvert.DeserializeObject<List<BlogDataModel>>(jsonStr)!;
                foreach (BlogDataModel item in lst)
                {
                    Console.WriteLine(item.Blog_Id);
                    Console.WriteLine(item.Blog_Title);
                    Console.WriteLine(item.Blog_Author);
                    Console.WriteLine(item.Blog_Content);
                }
            }
        }

        public async Task Edit(int id)
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest($"{_blogEndpoint}/{id}", Method.Get);
            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string jsonStr = response.Content!;
                BlogDataModel item = JsonConvert.DeserializeObject<BlogDataModel>(jsonStr)!;

                Console.WriteLine(item.Blog_Id);
                Console.WriteLine(item.Blog_Title);
                Console.WriteLine(item.Blog_Author);
                Console.WriteLine(item.Blog_Content);
            }
            else
            {
                Console.WriteLine(response.Content!);
            }
        }

        public async Task Create(string title, string author, string content)
        {
            var blog = new BlogDataModel
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };
            RestClient client = new RestClient();
            RestRequest request = new RestRequest(_blogEndpoint, Method.Post);
            request.AddJsonBody(blog);
            var response = await client.ExecuteAsync(request);

            Console.WriteLine(response.Content!);
        }

        public async Task Update(int id, string title, string author, string content)
        {
            BlogDataModel blog = new BlogDataModel
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };

            RestClient client = new RestClient();
            RestRequest request = new RestRequest($"{_blogEndpoint}/{id}", Method.Put);
            request.AddJsonBody(blog);

            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content!);
        }

        public async Task Delete(int id)
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest($"{_blogEndpoint}/{id}", Method.Delete);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content!);
        }
    }
}
