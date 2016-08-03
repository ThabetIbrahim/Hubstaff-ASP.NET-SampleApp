using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace screenshots_space
{
    public class screenshots : Controller
    {
        public IActionResult Index(){
            Dictionary <string, string[]> param = new Dictionary <string, string[]>();
            param["start_time"] = new string[] {"start_time"};
            param["stop_time"]   = new string[] {"stop_time"};
            param["offset"]   = new string[] {"offset"};
            param.Add("options", new string[] {"organizations","projects","users"});

            Dictionary <string, string> value_type = new Dictionary <string, string>();
            value_type["organizations"] = "input";
            value_type["projects"] = "input";
            value_type["users"] = "input";
            value_type["offset"] = "input";
            value_type["start_time"] = "datetime";
            value_type["stop_time"] = "datetime";
                        
            ViewBag.param = param;
            ViewBag.value_type = value_type;
            return View();
        }
        [HttpPost]
        public ActionResult Index(string start_time, string stop_time,int offset, Dictionary<string, string> options)
        {
            Dictionary <string, string[]> param = new Dictionary <string, string[]>();
            param["start_time"] = new string[] {"start_time"};
            param["stop_time"]   = new string[] {"stop_time"};
            param["offset"]   = new string[] {"offset"};
            param.Add("options", new string[] {"organizations","projects","users"});

            Dictionary <string, string> value_type = new Dictionary <string, string>();
            value_type["organizations"] = "input";
            value_type["projects"] = "input";
            value_type["users"] = "input";
            value_type["offset"] = "input";
            value_type["start_time"] = "datetime";
            value_type["stop_time"] = "datetime";
            
            ViewBag.param = param;
            ViewBag.value_type = value_type;
            hubstaff.client hubstaff_api = new hubstaff.client();
            
            ViewBag.screenshots = hubstaff_api.screehshots(start_time, stop_time, options, offset);

            return View();
        }

    }
}