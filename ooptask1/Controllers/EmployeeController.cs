using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ooptask1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View("Employee");
        }

        public IActionResult Index1()
        {
            String select = Request.Form["select"];
            if (select == "1")
            {
                //hour

            }
            else
            {

              //  fulltime

            }
            return  View("Employee");
        }





    }
}
