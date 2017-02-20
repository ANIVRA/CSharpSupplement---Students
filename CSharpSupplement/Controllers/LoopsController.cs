using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpSupplement.Controllers
{
    public class LoopsController : Controller
    {
        // GET: Loops
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WhileLoop()
        {
            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number);
                number = number + 1;
            }

            return View();
        }

        public ActionResult DoLoop()
        {
            int number = 0;

            do
            {
                Console.WriteLine(number);
                number = number + 1;
            } while (number < 5);

            return View();
        }

        public ActionResult ForLoop()
        {

            int number = 5;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }

            return View();
        }

        public ActionResult ForEachLoop()
        {

            ArrayList list = new ArrayList();
            list.Add("John Doe");
            list.Add("Jane Doe");
            list.Add("Someone Else");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            return View();
        }

    }
}