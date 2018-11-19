﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ViewResult Index()
        {
            string[] Names = { "黄武健", "韦安妮", "银浩然" };
            string[] Powers = { "班长", "副班长", "团支书" };
            ViewBag.Name = Names;
            ViewBag.Power = Powers;
            return View();
        }
    }
}