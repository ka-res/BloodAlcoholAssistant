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
            return View(new Person());
        }

        [HttpPost]
        public ViewResult Details(Person person)
        {
            return View(new AlcoholsViewModel(person.NumberOfAlcohols));
        }

        public ViewResult Result()
        {
            return View();
        }
    }
}