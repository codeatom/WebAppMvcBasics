using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcBasics.Models;

namespace WebAppMvcBasics.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(string temp)
        {
            if (!string.IsNullOrWhiteSpace(temp))
            {
                ViewBag.Msg = BodyTemperature.TemperatureStatus(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "Something went wrong. Please try again!";
                return View();
            }
        }
    }
}
