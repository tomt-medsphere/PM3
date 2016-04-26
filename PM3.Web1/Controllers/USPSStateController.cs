using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PM3.Model.Models;
using PM3.Service;
using PM3.Web1.Models;

namespace PM3.Web1.Controllers
{
    public class USPSStateController : Controller
    {
        private IUSPSStateService _uspsStateService;

        public USPSStateController(IUSPSStateService uspsStateService)
        {
            _uspsStateService = uspsStateService;
        }


        // GET: USPSStates
        public ActionResult Index()
        {
            return View(_uspsStateService.GetUSPSStates().ToList());
        }

        // GET: USPSStates/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USPSState uspsState = _uspsStateService.GetUSPSState(id);
            if (uspsState == null)
            {
                return HttpNotFound();
            }
            return View(uspsState);
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
        public ActionResult Create([Bind(Include = "USPSStateId,Name")] USPSState uspsState)
        {
            if (ModelState.IsValid)
            {
                _uspsStateService.CreateUSPSState(uspsState);
                _uspsStateService.SaveUSPSState();
                return RedirectToAction("Index");
            }

            return View(uspsState);
        }

        // GET: USPSStates/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USPSState uspsState = _uspsStateService.GetUSPSState(id);
            if (uspsState == null)
            {
                return HttpNotFound();
            }
            return View(uspsState);
        }

        // POST: USPSStates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "USPSStateId,Name")] USPSState uspsState)
        {
            if (ModelState.IsValid)
            {
                _uspsStateService.Update(uspsState);
                _uspsStateService.SaveUSPSState();
                return RedirectToAction("Index");
            }
            return View(uspsState);
        }

        // GET: USPSStates/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USPSState uspsState = _uspsStateService.GetUSPSState(id);
            if (uspsState == null)
            {
                return HttpNotFound();
            }
            return View(uspsState);
        }

        // POST: USPSStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            USPSState uspsState = _uspsStateService.GetUSPSState(id);
            _uspsStateService.Delete(uspsState);
            _uspsStateService.SaveUSPSState();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
