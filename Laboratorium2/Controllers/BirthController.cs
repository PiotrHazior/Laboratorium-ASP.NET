﻿using Laboratorium2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result()
        {
            

            return View();
        }
    }
}
