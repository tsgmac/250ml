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
    public class Event250mlController : Controller
    {
        private Event250mlDBContext db = new Event250mlDBContext();

        //
        // GET: /Event250ml/

        public ViewResult Index()
        {
            return View(db.Events250ml.ToList());
        }

        //
        // GET: /Event250ml/Details/5

        public ViewResult Details(int id)
        {
            Event250ml event250ml = db.Events250ml.Find(id);
            return View(event250ml);
        }

        //
        // GET: /Event250ml/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Event250ml/Create

        [HttpPost]
        public ActionResult Create(Event250ml event250ml)
        {
            if (ModelState.IsValid)
            {
                db.Events250ml.Add(event250ml);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(event250ml);
        }
        
        //
        // GET: /Event250ml/Edit/5
 
        public ActionResult Edit(int id)
        {
            Event250ml event250ml = db.Events250ml.Find(id);
            return View(event250ml);
        }

        //
        // POST: /Event250ml/Edit/5

        [HttpPost]
        public ActionResult Edit(Event250ml event250ml)
        {
            if (ModelState.IsValid)
            {
                db.Entry(event250ml).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(event250ml);
        }

        //
        // GET: /Event250ml/Delete/5
 
        public ActionResult Delete(int id)
        {
            Event250ml event250ml = db.Events250ml.Find(id);
            return View(event250ml);
        }

        //
        // POST: /Event250ml/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Event250ml event250ml = db.Events250ml.Find(id);
            db.Events250ml.Remove(event250ml);
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