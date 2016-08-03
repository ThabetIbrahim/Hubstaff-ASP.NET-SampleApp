using Microsoft.AspNetCore.Mvc;

namespace dashboard_space
{
    public class Dashboard : Controller
    {
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public ActionResult Index(string App_token, string email, string password, string operation)
        {
            hubstaff.client hubstaff_api = new hubstaff.client();
            ViewBag.Data = hubstaff_api.auth(App_token,email,password);;
            ViewBag.email = email;
            ViewBag.password = password;
            ViewBag.app_token = App_token;
            return View();
        }

    }
}