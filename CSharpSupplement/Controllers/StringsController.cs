using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CSharpSupplement.Controllers
{
    public class StringsController : Controller
    {
        // GET: Strings
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SBExample(string str)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
            }

            switch (str)
            {
                case "build":
                    // Create a string composed of numbers 0 - 9
                    ViewBag.Result = sb;
                    break;

                case "replace":
                    sb[0] = sb[9];
                    ViewBag.Result = sb;
                    break;

                case "reverse":
                    string myStr = MyReverse(sb);
                    ViewBag.Result = myStr;
                    break;
                default:
                    ViewBag.Result = "";
                    break;
            }

            return View();
        }




        private string MyReverse(StringBuilder sb)
        {
            string s = sb.ToString();

            StringBuilder builder = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                builder.Append(s[i]);
            }

            return builder.ToString();

        }
    }
}