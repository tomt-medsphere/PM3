using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PM3.Model.Models;
using PM3.Web1.Models;

namespace PM3.Web1.Controllers
{
    public class USPSStatesController : Controller
    {
        private PM3Web1Context db = new PM3Web1Context();

        // GET: USPSStates
        public ActionResult Index()
        {
            return View(db.USPSStates.ToList());
        }

        // GET: USPSStates/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USPSState uSPSState = db.USPSStates.Find(id);
            if (uSPSState == null)
            {
                return HttpNotFound();
            }
            return View(uSPSState);
        }

        // GET: USPSStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: USPSStates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "USPSStateId,Name")] USPSState uSPSState)
        {
            if (ModelState.IsValid)
            {
                db.USPSStates.Add(uSPSState);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uSPSState);
        }

        // GET: USPSStates/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USPSState uSPSState = db.USPSStates.Find(id);
            if (uSPSState == null)
            {
                return HttpNotFound();
            }
            return View(uSPSState);
        }

        // POST: USPSStates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "USPSStateId,Name")] USPSState uSPSState)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uSPSState).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uSPSState);
        }

        // GET: USPSStates/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USPSState uSPSState = db.USPSStates.Find(id);
            if (uSPSState == null)
            {
                return HttpNotFound();
            }
            return View(uSPSState);
        }

        // POST: USPSStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            USPSState uSPSState = db.USPSStates.Find(id);
            db.USPSStates.Remove(uSPSState);
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
