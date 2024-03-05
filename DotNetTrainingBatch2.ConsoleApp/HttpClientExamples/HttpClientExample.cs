using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetTrainingBatch2.ConsoleApp.Models;
using static System.Net.Mime.MediaTypeNames;

namespace DotNetTrainingBatch2.ConsoleApp.HttpClientExamples
{
    public class HttpClientExample
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
            //await Update(4004, "New Title", "New Author", "New Content");
            //await Delete(5);
        }
        #region Read
        public async Task Read()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(_blogEndpoint);
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
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
        #endregion

        #region Edit
        public async Task Edit(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"{_blogEndpoint}/{id}");
            if (response.IsSuccessStatusCode)
            {
                string jsonStr = await response.Content.ReadAsStringAsync();
                BlogDataModel item = JsonConvert.DeserializeObject<BlogDataModel>(jsonStr)!;

                Console.WriteLine(item.Blog_Id);
                Console.WriteLine(item.Blog_Title);
                Console.WriteLine(item.Blog_Author);
                Console.WriteLine(item.Blog_Content);
            }
            else
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
        }
        #endregion

        #region Create
        public async Task Create(string title, string author, string content)
        {
            var blog = new BlogDataModel
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };
            string jsonBlog = JsonConvert.SerializeObject(blog);
            HttpContent httpContent = new StringContent(jsonBlog, Encoding.UTF8, Application.Json);

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync(_blogEndpoint, httpContent);
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
        #endregion

        #region Update
        public async Task Update(int id, string title, string author, string content)
        {
            BlogDataModel blog = new BlogDataModel
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };

            string jonBlog = JsonConvert.SerializeObject(blog);

            HttpContent httpContent = new StringContent(jonBlog, Encoding.UTF8, Application.Json);

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PutAsync($"{_blogEndpoint}/{id}", httpContent);
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
        #endregion

        #region Delete
        public async Task Delete(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync($"{_blogEndpoint}/{id}");
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
        #endregion
    }
}
