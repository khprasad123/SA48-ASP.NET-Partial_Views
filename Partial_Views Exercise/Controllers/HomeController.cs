using Partial_Views_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Partial_Views_Exercise.Controllers
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

        public ActionResult PartialViews(string choice)
        {
            UserModel user  = new UserModel("Harirpasad","khprasad123@gmail.com");
            ViewData["user"] = user;
            if (choice == "transact")
            {
                List<TransactModels> list = new List<TransactModels>();
                TransactModels p1  = new TransactModels("Washing Powder","Nirma",260);
                list.Add(p1);
                TransactModels p2 = new TransactModels("Chicken Masala", "Eastern", 60);
                list.Add(p2);
                ViewData["transact"] = list;

            }
            else if (choice == "complain")
            {
                List<ComplaintModels> list = new List<ComplaintModels>();
                ComplaintModels c1 = new ComplaintModels("Washing Powder", "Hands getting itchy");
                list.Add(c1);
                ComplaintModels c2 = new ComplaintModels("Chicken Masala", "Very Bad Taste");
                list.Add(c2);
                ViewData["complain"] = list;
            }

            ViewData["type"] = choice;
            return View();
        }
    }
}