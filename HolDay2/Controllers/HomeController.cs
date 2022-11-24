using HolDay2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HolDay2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1>This is a demo of  ContentResult </ h1 > ");
            }
            else if (id.ToLower() == "plain")

            {
                return Content("<h1>This is a demo of  ContentResult </ h1 > ", "text / plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1>This is a demo of   ContentResult </ h1 > ", "text / html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1>This is a demo   ContentResult </ h1 > ", "text / xml");
            }
            return Content("Invalid content type");
        }
        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"C:\Users\lighthouse.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"C:\Users\lighthouse.jpg", "image /jpg", "default.jpg");
        }
        public ActionResult Google()
        {
            return Redirect("http://www.google.com");
        }
        public ActionResult StartPage()
        {
            return RedirectToAction("Index", new { id = "xml" });
        }
        public ActionResult Login() { return View(); }
        public ActionResult AboutUs() { return View(); }
    }
}
