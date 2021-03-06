﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cart()
        {

            return View();
        }

        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Products()
        {

            return View();
        }

        public ActionResult ContactUs()
        {

            return View();
        }

        public ActionResult Checkout()
        {

            return View();
        }

        public ActionResult ProductDetails()
        {

            return View();
        }
        
        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult BlogSingle()
        {
            return View();
        }
    }
}