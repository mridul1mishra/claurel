using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using code.Models;

namespace code.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }

        public ActionResult breakingsilos()
        {
            ViewBag.Message = "Your application description page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }

        public ActionResult customerjourney()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult demandgeneration()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult driverevenue()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult leadmanagement()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult marketingcampaign()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult omnichannel()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult persona()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult personalization()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult profiling()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult forms()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult machinelearning()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult azurescaleout()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult machinelearningproject()
        {
            ViewBag.Message = "Your contact page.";
            var a = Request.RawUrl;
            var p = new PageMetaDetails(a);
            return View(p);
        }
        public ActionResult error()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }

    }
}