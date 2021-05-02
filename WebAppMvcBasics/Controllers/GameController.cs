using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcBasics.Models;

namespace WebAppMvcBasics.Controllers
{
    public class GameController : Controller
    {
        [HttpGet]
        public IActionResult GuessNumber()
        {
            HttpContext.Session.SetInt32("secretNumber", GameNumbers.GetRandomNum());
            return View();
        }

        [HttpPost]
        public IActionResult GuessNumber(string guessedNum)
        {
            if (!string.IsNullOrWhiteSpace(guessedNum))
            {
                int secretNum = (int)HttpContext.Session.GetInt32("secretNumber");
                ViewBag.msg = GameNumbers.compareNumbers(guessedNum, secretNum);
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
