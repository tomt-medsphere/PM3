using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PM3.Data.Repositories;
using PM3.Model.Models;
using PM3.Service;

namespace PM3.Web1.Controllers
{
    public class DocumentCategoryController : Controller
    {
        // initialize the service object
        private IDocumentCategoryService _documentCategoryService;

        public DocumentCategoryController(IDocumentCategoryService documentCategoryService)
        {
            _documentCategoryService = documentCategoryService;
        }

        // GET: DocumentCategory
        public ActionResult Index()
        {
            return View(_documentCategoryService.GetDocumentCategorys().ToList());
        }

        // GET: DocumentCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DocumentCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccidentCode/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DocumentCategoryId,Description")] DocumentCategory documentCategory)
        {
            if (ModelState.IsValid)
            {
                _documentCategoryService.CreateDocumentCategory(documentCategory);
                _documentCategoryService.SaveDocumentCategory();
                return RedirectToAction("Index");
            }

            return View(documentCategory);
        }

        // GET: DocumentCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DocumentCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DocumentCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DocumentCategory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
