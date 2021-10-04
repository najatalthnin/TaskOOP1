using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ooptask1.Models;

namespace ooptask1.Controllers
{
    public class Employee1Controller : Controller
    {
        public IActionResult Index()
        {
            return View("Employee");
        }

        public IActionResult Index1()
        {
            String select = Request.Form["select"];
            if (select == "Hourly")
            {
                HourEM hEmp = new HourEM();


                


            }
            else
            {
                FulltimeEM FEmp = new FulltimeEM();


            }
            return View("Employee");
        }
    }
}
