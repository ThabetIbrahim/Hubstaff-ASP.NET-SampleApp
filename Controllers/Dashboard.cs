using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace dashboard_space
{
    public class Dashboard : Controller
    {
        public hubstaff.client hubstaff_api = new hubstaff.client("pHR18-G-9c05NoyBtji3a8A2KsFKOuZcSZK4gT5V9vc");

        public IActionResult Index(){
            Dictionary<string, string> auth_token_data = new Dictionary<string, string>();
            auth_token_data["error"]       = "";
            auth_token_data["auth_token"]  = hubstaff_api.get_auth_token();
            ViewBag.Data = auth_token_data;
            return View();
        }
        [HttpPost]
        public ActionResult Index(string email, string password, string operation)
        {
            ViewBag.Data = hubstaff_api.auth(email,password);;
            ViewBag.email = email;
            ViewBag.password = password;
            return View();
        }

    }
}