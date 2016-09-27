using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo0927_02.Controllers
{
    public class HomeController : Controller
    {

        public string Index2()
        {
            return "Hello from Web Server, åäö";
        }


        // GET: Home
        public ActionResult Index()
        {
            //Per default hamnar vi här
            //pga MS MVC Conventions

            //Var är våran VIEW?
            //Vad heter vår VIEW?
            //Per default ska den heta INDEX
            //dvs samma som denna metod heter
            return View();
        }
    }
}