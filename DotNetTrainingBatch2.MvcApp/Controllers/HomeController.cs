using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DotNetTrainingBatch2.MvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch2.MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var auth = Request.Cookies["Auth"];
            if (auth is not null)
            {
                var isExist = await _appDbContext.ValidateTokenAsync(auth);
                if (!isExist)
                {
                    return View();
                }
                return Redirect("/Blog");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRequestModel user)
        {
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
            {
                return View();
            }

            var item = await _appDbContext.Users.FirstOrDefaultAsync(x =>
                x.UserName == user.UserName &&
                x.Password == user.Password);
            if (item is null)
            {
                return View();
            }

            item.GeneratedToken = Guid.NewGuid().ToString(); //32 (a, n), 4 -
            await _appDbContext.SaveChangesAsync();

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Append("Auth", item.GeneratedToken, options);

            //return View();
            return Redirect("/Blog");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class UserRequestModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public static class AppDbContextExtensions
    {
        public static async Task<bool> ValidateTokenAsync(this AppDbContext appDbContext, string token)
        {
            return await appDbContext.Users.AnyAsync(x => x.GeneratedToken == token);
        }
    }
}
