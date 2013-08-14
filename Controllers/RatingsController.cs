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
    public class RatingsController : Controller
    {
        private DBContext db = new DBContext();

        //
        // GET: /Ratings/

        public ViewResult Index()
        {
            return View(db.Ratinglist.ToList());
        }

        //
        // GET: /Ratings/Details/5

        public ViewResult Details(int id)
        {
            Ratings ratings = db.Ratinglist.Find(id);
            return View(ratings);
        }

        //
        // GET: /Ratings/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Ratings/Create

        [HttpPost]
        public ActionResult Create(Ratings ratings)
        {
            if (ModelState.IsValid)
            {
                db.Ratinglist.Add(ratings);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(ratings);
        }
        
        //
        // GET: /Ratings/Edit/5
 
        public ActionResult Edit(int id)
        {
            Ratings ratings = db.Ratinglist.Find(id);
            return View(ratings);
        }

        //
        // POST: /Ratings/Edit/5

        [HttpPost]
        public ActionResult Edit(Ratings ratings)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ratings).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ratings);
        }

        //
        // GET: /Ratings/Delete/5
 
        public ActionResult Delete(int id)
        {
            Ratings ratings = db.Ratinglist.Find(id);
            return View(ratings);
        }

        //
        // POST: /Ratings/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Ratings ratings = db.Ratinglist.Find(id);
            db.Ratinglist.Remove(ratings);
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