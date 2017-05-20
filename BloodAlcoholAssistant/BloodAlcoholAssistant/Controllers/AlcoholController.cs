using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodAlcoholAssistant.Controllers
{
    public class AlcoholController : Controller
    {
        public ViewResult Welcome() 
        {
            return View();
        }

        public ViewResult Details()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ViewResult Result()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}