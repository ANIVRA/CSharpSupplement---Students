using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpSupplement.Controllers
{
    public class OperatorsController : Controller
    {
        // GET: Operators
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult UnaryPlus(string unop)
        {
            ViewBag.Message = "Plus Operator";

            return View();
        }

        //++ operator
        public ActionResult PlusPlus(string incr)
        {

            return View();
        }


        public ActionResult Minus(string sub)
        {
            int a = 5;
            switch (sub)
            {
                case "-a":
                    ViewBag.Result = -a;
                    break;
                case "":
                    Console.WriteLine(a - 1);
                    break;
                case "a - .5":
                    Console.WriteLine(a - .5);
                    break;
                default:
                    ViewBag.Result = "";
                    break;
            }
            return View();
        }
    }

}


