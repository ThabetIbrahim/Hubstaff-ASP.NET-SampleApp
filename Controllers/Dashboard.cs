using Microsoft.AspNetCore.Mvc;

namespace dashboard_space
{
    public class Dashboard : Controller
    {
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public ActionResult Index(string email, string password, string operation)
        {
            aspnetcoreapp.hubstaff_api hubstaff_api = new aspnetcoreapp.hubstaff_api();
            ViewBag.Data = hubstaff_api.auth(email,password);
            ViewBag.email = email;
            ViewBag.password = password;
            return View();
        }

    }
}