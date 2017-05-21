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
            if (HttpContext.Session != null)
                HttpContext.Session["Person"] = person;
            return View();
        }

        public ActionResult Calculate(AlcoholsViewModel alcoVm)
        {
            if (HttpContext.Session != null)
                HttpContext.Session["Alcohols"] = alcoVm;
            return RedirectToAction("Result");
        }

        public ActionResult Result(ResultViewModel resultVm)
        {
            if (HttpContext.Session != null)
                resultVm.GetResult(
                    HttpContext.Session["Person"] as Person,
                    HttpContext.Session["Alcohols"] as AlcoholsViewModel);
            return View(resultVm);
        }
    }
}