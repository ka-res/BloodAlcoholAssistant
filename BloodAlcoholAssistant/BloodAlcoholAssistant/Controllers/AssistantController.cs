using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BloodAlcoholAssistant.Models;

namespace BloodAlcoholAssistant.Controllers
{
    public class AssistantController : Controller
    {
        public ViewResult Welcome() 
        {
            return View();
        }

        public ViewResult Details(Person person)
        {
            HttpContext.Session["Person"] = person;
            return View();
        }

        public ActionResult Calculate(AlcoholsViewModel alcoVm)
        {
            HttpContext.Session["Alcohols"] = alcoVm;
            return RedirectToAction("Result");
        }

        public ActionResult Result(ResultViewModel resultVm)
        {
            resultVm.GetResult(
                HttpContext.Session["Person"] as Person, 
                HttpContext.Session["Alcohols"] as AlcoholsViewModel);
            return View(resultVm);
        }
    }
}