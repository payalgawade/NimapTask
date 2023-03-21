using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication30.Models;
using PagedList.Mvc;
using PagedList;



namespace WebApplication30.Controllers
{
    public class HomeController : Controller
    {
        companytaskcontext ctc = new companytaskcontext();        


        // GET: Home
        public ActionResult Index(string SortOrder, string SortBy, int? i)
        {

            var v = ctc.f1.ToList().ToPagedList(i ?? 1, 10);

            return View(v);

        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(companytask f)
        {
            ctc.f1.Add(f);
            ctc.SaveChanges();
            Response.Write("<script>alert('data insert successfully')</script>");
            return View();
        }


        [HttpGet]

        public ActionResult Delete(int id)
        {
            var t = ctc.f1.Where(model => model.Id == id).FirstOrDefault();
            return View(t);
        }

        [HttpPost]

        public ActionResult Delete(companytask q)
        {
            ctc.Entry(q).State = System.Data.Entity.EntityState.Deleted;
            ctc.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]

        public ActionResult Edit(int id)
        {
            var t = ctc.f1.Where(model => model.Id == id).FirstOrDefault();
            return View(t);
        }

        [HttpPost]

        public ActionResult Edit(companytask q)
        {
            ctc.Entry(q).State = System.Data.Entity.EntityState.Modified;
            ctc.SaveChanges();
            return RedirectToAction("Index");
        }
       
        [HttpGet]

        public ActionResult Details(int id)
        {
            var t = ctc.f1.Where(model => model.Id == id).FirstOrDefault();
            return View(t);
        }
    }
}