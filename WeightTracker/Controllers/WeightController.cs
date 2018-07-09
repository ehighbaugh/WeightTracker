using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WeightTracker.Data;
using WeightTracker.Models;

namespace WeightTracker.Controllers
{
    public class WeightController : Controller
    {
        private WeightContext db = new WeightContext();

        // GET: Weight
        public ActionResult Index()
        {
            return View(db.Weights.ToList());
        }

        // GET: Weight/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeightMs weightMs = db.Weights.Find(id);
            if (weightMs == null)
            {
                return HttpNotFound();
            }
            return View(weightMs);
        }

        // GET: Weight/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Weight/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Units,Date,Amount")] WeightMs weightMs)
        {
            if (ModelState.IsValid)
            {
                db.Weights.Add(weightMs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(weightMs);
        }

        // GET: Weight/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeightMs weightMs = db.Weights.Find(id);
            if (weightMs == null)
            {
                return HttpNotFound();
            }
            return View(weightMs);
        }

        // POST: Weight/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Units,Date,Amount")] WeightMs weightMs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weightMs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weightMs);
        }

        // GET: Weight/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeightMs weightMs = db.Weights.Find(id);
            if (weightMs == null)
            {
                return HttpNotFound();
            }
            return View(weightMs);
        }

        // POST: Weight/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WeightMs weightMs = db.Weights.Find(id);
            db.Weights.Remove(weightMs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
