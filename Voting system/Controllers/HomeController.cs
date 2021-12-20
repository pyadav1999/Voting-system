using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Voting_system.Context;
using Voting_system.Models;
using Voting_system.Repository;

namespace Voting_system.Controllers
{
    public class HomeController : Controller
    {
        //private IimgReository _imgrepo;
     
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