using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _250ml.Models;

namespace _250ml.Controllers
{ 
    public class EventsController : Controller
    {
        private DBContext db = new DBContext();

        //
        // GET: /Events/

        public ViewResult Index()
        {
            return View(db.Eventlist.ToList());
        }

        //
        // GET: /Events/Details/5

        public ViewResult Details(int id)
        {
            Events events = db.Eventlist.Find(id);
            return View(events);
        }

        //
        // GET: /Events/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Events/Create

        [HttpPost]
        public ActionResult Create(Events events)
        {
            if (ModelState.IsValid)
            {
                db.Eventlist.Add(events);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(events);
        }
        
        //
        // GET: /Events/Edit/5
 
        public ActionResult Edit(int id)
        {
            Events events = db.Eventlist.Find(id);
            return View(events);
        }

        //
        // POST: /Events/Edit/5

        [HttpPost]
        public ActionResult Edit(Events events)
        {
            if (ModelState.IsValid)
            {
                db.Entry(events).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(events);
        }

        //
        // GET: /Events/Delete/5
 
        public ActionResult Delete(int id)
        {
            Events events = db.Eventlist.Find(id);
            return View(events);
        }

        //
        // POST: /Events/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Events events = db.Eventlist.Find(id);
            db.Eventlist.Remove(events);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}