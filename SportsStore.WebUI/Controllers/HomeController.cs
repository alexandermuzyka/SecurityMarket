﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
          //  ViewBag.MyMessageToUsers = "Hello";
            //ViewBag.AnswerText = "Your Answers goes here";
      
            return View();
        }
    }
}