using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    public class FruitsController : Controller
    {
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[Action]")]

        public IActionResult Asian()
        {
            return View();
        }
        [Route("Bangla")]
        public IActionResult Deshi()
        {
            return View();
        }
        [Route("[Action]")]

        public IActionResult Australian()
        {
            return View();
        }
    }
}