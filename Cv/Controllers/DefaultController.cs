using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cv.Models.Entity;

namespace Cv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCVEntities db = new DbCVEntities();
        public ActionResult Index()
        {
            var values = db.AboutMes.ToList();
            return View(values);
        }

        public PartialViewResult Experience()
        {
            var experience = db.Experiences.ToList();
            return PartialView(experience);
        }

        public PartialViewResult Education()
        {
            var edu = db.Educations.ToList();
            return PartialView(edu);
        }

        public PartialViewResult Skills()
        {
            var s = db.Skills.ToList();
            return PartialView(s);
        }

        public PartialViewResult Interests()
        {
            var i= db.Interests.ToList();
            return PartialView(i);
        }

        public PartialViewResult Awards()
        {
            var a = db.Awards.ToList();
            return PartialView(a);
        }
        [HttpGet]
        public PartialViewResult Contact()
        {
            var a = db.Contacts.ToList();
            return PartialView(a);
        }
        [HttpPost]
        public PartialViewResult Contact(Contact t)
        {
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Contacts.Add(t);
            db.SaveChanges();
            return PartialView();
        }


    }


}