using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpSupplement.Controllers
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

        public ActionResult HelloWorld()
        {
            ViewBag.Message = "Hello World";

            return View();
        }

        public ActionResult Variables(string oper8r)
        {
            ViewBag.Message = "Variables";

            int x, y, result;
            x = ViewBag.X = 5;
            y = ViewBag.Y = 10;
            switch (oper8r)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
                default:
                    result = 0;
                    break;
                 
            }

            ViewBag.Result = result;

            return View();
        }

    }
}