using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AKLMPSTYZDotNetCore.RestApi.Controllers
{
    //https://localhost:3000/api/blog
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly AppDbContext _dbContext = new AppDbContext();

        [HttpGet]
        public IActionResult GetBlogs()
        {
            var lst = _dbContext.Blogs.ToList();
            return Ok(lst);
        }

        [HttpPost]
        public IActionResult CreateBlog()
        {
            return Ok("post");
        }

        [HttpPut]
        public IActionResult UpdateBlog()
        {
            return Ok("put");
        }

        [HttpPatch]
        public IActionResult PatchBlog()
        {
            return Ok("patch");
        }

        [HttpDelete]
        public IActionResult DeleteBlog()
        {
            return Ok("delete");
        }
    }
}
