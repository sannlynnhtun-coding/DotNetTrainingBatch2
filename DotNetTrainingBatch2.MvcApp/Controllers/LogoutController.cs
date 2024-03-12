using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DotNetTrainingBatch2.MvcApp.Controllers
{
    public class LogoutController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            Response.Cookies.Delete("Auth");
            return Redirect("/");
        }
    }
}
