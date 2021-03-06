﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PM3.Data;
using PM3.Model.Models;
using PM3.Service;

namespace PM3.Web1.Controllers
{
    public class AccidentCodeController : Controller
    {

        // initialize the service object
        private IAccidentCodeService _accidentCodeService;

        public AccidentCodeController(IAccidentCodeService accidentCodeService)
        {
            _accidentCodeService = accidentCodeService;
        }

        // GET: AccidentCode
        public ActionResult Index()
        {
            return View(_accidentCodeService.GetAccidentCodes().ToList());
        }

        // GET: AccidentCode/Details/A
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccidentCode accidentCode = _accidentCodeService.GetAccidentCode(id);
            if (accidentCode == null)
            {
                return HttpNotFound();
            }
            return View(accidentCode);
        }

        // GET: AccidentCode/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccidentCode/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccidentCodeId,Description")] AccidentCode accidentCode)
        {
            if (ModelState.IsValid)
            {
                _accidentCodeService.CreateAccidentCode(accidentCode);
                _accidentCodeService.SaveAccidentCode();
                return RedirectToAction("Index");
            }

            return View(accidentCode);
        }

        // GET: AccidentCode/Edit/A
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccidentCode accidentCode = _accidentCodeService.GetAccidentCode(id);
            if (accidentCode == null)
            {
                return HttpNotFound();
            }
            return View(accidentCode);
        }

        // POST: AccidentCode/Edit/A
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccidentCodeID,Description")] AccidentCode accidentCode)
        {
            if (ModelState.IsValid)
            {
                _accidentCodeService.Update(accidentCode);
                _accidentCodeService.SaveAccidentCode();
                return RedirectToAction("Index");
            }
            return View(accidentCode);
        }

        // GET: AccidentCode/Delete/A
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccidentCode accidentCode = _accidentCodeService.GetAccidentCode(id);
            if (accidentCode == null)
            {
                return HttpNotFound();
            }
            return View(accidentCode);
        }

        // POST: AccidentCode/Delete/A
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AccidentCode accidentCode = _accidentCodeService.GetAccidentCode(id);
            _accidentCodeService.Delete(accidentCode);
            _accidentCodeService.SaveAccidentCode();
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}


    }
}