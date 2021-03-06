﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.SendMessage guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("MessageResponse", guestResponse);
            } else
            {
                return View();
            }
        }
    }
}