using MVC_Tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";

            //Random rnd = new Random();
            //int num = rnd.Next();

            //if (num > 20000 )
            //{
            //    return View("About");  // this is how we return a different view.  Type the view name and as long as
            //                           // the view name is in the controller you're good.
            //}

            //ViewBag.RandomNumber = num;

            //System.IO.File.WriteAllText(@"c:\Users\Andy\Logs\MVCDemoLog.txt",text);
            //return View();  // returns the _layout.cshtml page plus any customizaions from index.cshtml

            //return Content("Hello Andy");
            //return Content(""); // returns nothing and sometimes comes in handy

            //return View("Contact"); // returns the view; doesn't take any of the actions in the contact controller
            //return RedirectToAction("Contact"); // returns the view and takes the actions in the contact controller


            //List<string> names = new List<string>
            //{
            //    "Andy",
            //    "Amanda",
            //    "Brett"
            //};

            //int number = 5;
            //return View(number);  
            //return View(names);  

            User user = new User();  // Whatever you pass to the view becomes the Model, can only pass 1 model
            user.Id = 1;
            user.FirstName = "Andy";
            user.LastName = "Lorenz";
            user.Age = 29; // ;)
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description Andy.";

            //throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;
            //ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}