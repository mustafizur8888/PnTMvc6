using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            @ViewBag.tttt = "aaaa";
            return View();

        }

        public IActionResult Mobile()
        {
            return View();
        }

        

    }
}