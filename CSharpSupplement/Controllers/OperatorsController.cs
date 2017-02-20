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

            switch (unop)
            {
                case "+5":
                    ViewBag.Result = +5;        // unary plus
                    break;
                case "5 + 5":
                    ViewBag.Result = 5 + 5;     // addition
                    break;
                case "5 + .5":
                    ViewBag.Result = 5 + .5;    // addition
                    break;
                case "''5'' + ''5''":
                    ViewBag.Result = "5" + "5";  // string concatenation
                    break;
                case "5.0 + ''5''":
                    ViewBag.Result = 5.0 + "5";  // string concatenation
                                                 // note automatic conversion from double to string
                    break;
                default:
                    ViewBag.Result = "";
                    break;
            }
            return View();
        }

        //++ operator
        public ActionResult PlusPlus(string incr)
        {
            double x;
            x = 1.5;
            switch (incr)
            {
                case "++x":
                    ViewBag.Result = ++x;
                    break;
                case "x++":
                    ViewBag.Result = x++;
                    break;
                case "x":
                    x++;
                    ViewBag.Result = x;
                    break;
                default:
                    ViewBag.Result = "";
                    break;
            }
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


