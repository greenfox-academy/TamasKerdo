﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IAmGroot.Controllers
{
    [Route("")]
    public class GuardianController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("groot")]
        public IActionResult GetGroot([FromQuery] string message)
        {
            if (message != null)
            {
                return Json(new { received = message, translated = "I am Groot!" });
            }
            return Json(new { error = "I am Groot!" });
        }

    }
}
