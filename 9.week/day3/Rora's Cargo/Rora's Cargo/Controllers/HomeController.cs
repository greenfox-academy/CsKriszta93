﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace RorasCargo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/rocket")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
