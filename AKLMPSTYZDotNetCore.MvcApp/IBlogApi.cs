using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKLMPSTYZDotNetCore.MvcApp.Models;

namespace AKLMPSTYZDotNetCore.MvcApp
{
    public interface IBlogApi
    {
        [Get("/api/blog")]
        Task<List<BlogDataModel>> GetBlogs();

        [Get("/api/blog/{id}")]
        Task<BlogDataModel> GetBlog(int id);

        [Post("/api/blog")]
        Task<string> CreateBlog(BlogDataModel blog);
    }
}
