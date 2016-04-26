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
    public class BillingAccountTypeController : Controller
    {
        // initialize the service object
        private IBillingAccountTypeService _billingAccountTypeService;

        public BillingAccountTypeController(IBillingAccountTypeService billingAccountTypeService)
        {
            _billingAccountTypeService = billingAccountTypeService;
        }


        // GET: BillingAccountTypes
        public ActionResult Index()
        {
            return View(_billingAccountTypeService.GetBillingAccountTypes().ToList());
        }

        // GET: BillingAccountTypes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillingAccountType billingAccountType = _billingAccountTypeService.GetBillingAccountType(id);
            if (billingAccountType == null)
            {
                return HttpNotFound();
            }
            return View(billingAccountType);
        }

        // GET: BillingAccountTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillingAccountTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BillingAccountTypeId,Description,Billable,Dunning,Inactive")] BillingAccountType billingAccountType)
        {
            if (ModelState.IsValid)
            {
                _billingAccountTypeService.CreateBillingAccountType(billingAccountType);
                _billingAccountTypeService.SaveBillingAccountType();
                return RedirectToAction("Index");
            }

            return View(billingAccountType);
        }

        // GET: BillingAccountTypes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillingAccountType billingAccountType = _billingAccountTypeService.GetBillingAccountType(id);
            if (billingAccountType == null)
            {
                return HttpNotFound();
            }
            return View(billingAccountType);
        }

        // POST: BillingAccountTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BillingAccountTypeId,Description,Billable,Dunning,Inactive")] BillingAccountType billingAccountType)
        {
            if (ModelState.IsValid)
            {
                _billingAccountTypeService.Update(billingAccountType);
                _billingAccountTypeService.SaveBillingAccountType();
                return RedirectToAction("Index");
            }
            return View(billingAccountType);
        }

        // GET: BillingAccountTypes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BillingAccountType billingAccountType = _billingAccountTypeService.GetBillingAccountType(id);
            if (billingAccountType == null)
            {
                return HttpNotFound();
            }
            return View(billingAccountType);
        }

        // POST: BillingAccountTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BillingAccountType billingAccountType = _billingAccountTypeService.GetBillingAccountType(id);
            _billingAccountTypeService.Delete(billingAccountType);
            _billingAccountTypeService.SaveBillingAccountType();
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
