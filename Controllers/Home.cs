using Microsoft.AspNetCore.Mvc;
namespace home_space
{
    public class Home : Controller
    {
        [HttpGet("/")]
        public IActionResult Index(){
            return View();
        }

    }
}