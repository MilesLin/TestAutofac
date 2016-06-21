using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAutofac.Models;

namespace TestAutofac.Controllers
{
    public class HomeController : Controller
    {
        IPersonsRepository _personRepo;
        public HomeController(IPersonsRepository personRepo)
        {
            this._personRepo = personRepo;

            //here occurred exception, because UnitOfWork is null
            var testResult = this._personRepo.All().ToList();
        }

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
    }
}