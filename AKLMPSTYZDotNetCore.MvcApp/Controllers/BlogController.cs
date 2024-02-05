using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AKLMPSTYZDotNetCore.MvcApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public BlogController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var lst = await _appDbContext.Blogs.ToListAsync();
            return View(lst);
        }
    }
}
