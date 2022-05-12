using DATA_FIRST_APPROCH.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DATA_FIRST_APPROCH.Controllers
{
    public class HomeController : Controller
    {
        StudentsContext db = new StudentsContext();
        public ActionResult Index()
        {
            var res = db.Students.ToList();
            return View(res);
        }
        public ActionResult Delete(int id)
        {
            var n = db.Students.Where(model => model.id == id).FirstOrDefault();
            db.Entry(n).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var val = db.Students.Where(model => model.id == id).FirstOrDefault();
            return View(val);
        }
        [HttpPost]
        public ActionResult Edit(Students std)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(std).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("index");

        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Students s)
        {
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
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