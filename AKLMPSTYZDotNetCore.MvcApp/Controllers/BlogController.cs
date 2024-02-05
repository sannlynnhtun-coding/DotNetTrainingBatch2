using AKLMPSTYZDotNetCore.MvcApp.Models;
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
            var lst = await _appDbContext.Blogs
                .OrderByDescending(x => x.Blog_Id)
                .ToListAsync();
            return View(lst);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(BlogDataModel requestModel)
        {
            await _appDbContext.Blogs.AddAsync(requestModel);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var item = await _appDbContext.Blogs.FirstOrDefaultAsync(x => x.Blog_Id == id);
            if (item is null)
                return RedirectToAction("Index");

            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, BlogDataModel requestModel)
        {
            var item = await _appDbContext.Blogs.FirstOrDefaultAsync(x => x.Blog_Id == id);
            if (item is null)
                return RedirectToAction("Index");

            item.Blog_Title = requestModel.Blog_Title;
            item.Blog_Author = requestModel.Blog_Author;
            item.Blog_Content = requestModel.Blog_Content;
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var item = await _appDbContext.Blogs.FirstOrDefaultAsync(x => x.Blog_Id == id);
            if(item is null)
                return RedirectToAction("Index");

            _appDbContext.Remove(item);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
