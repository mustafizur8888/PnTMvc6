using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }

        public IActionResult Mobile()
        {
            return View();
        }



    }
}