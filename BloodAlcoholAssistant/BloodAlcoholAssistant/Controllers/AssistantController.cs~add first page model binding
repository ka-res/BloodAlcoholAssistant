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

        public ViewResult Details()
        {
            return View();
        }

        public ViewResult Result()
        {
            return View();
        }

        public Person BuildPersonInfo(double weightAsKilo, Gender sex, int numberOfAlcoholos)
        {
            return new Person {WeightAsKilo = weightAsKilo, Sex = sex, NumberOfAlcohols = numberOfAlcoholos};
        }
    }
}