using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirstData.DAL;
using CodeFirstData.Models;

namespace CodeFirstData.Controllers
{
    public class DatamodelController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Datamodel
        public ActionResult Index()
        {
            return View(db.Datamodels.ToList());
        }

        // GET: Datamodel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datamodel datamodel = db.Datamodels.Find(id);
            if (datamodel == null)
            {
                return HttpNotFound();
            }
            return View(datamodel);
        }

        // GET: Datamodel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Datamodel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ExampleFirstName,ExampleLastName")] Datamodel datamodel)
        {
            if (ModelState.IsValid)
            {
                db.Datamodels.Add(datamodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datamodel);
        }

        // GET: Datamodel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datamodel datamodel = db.Datamodels.Find(id);
            if (datamodel == null)
            {
                return HttpNotFound();
            }
            return View(datamodel);
        }

        // POST: Datamodel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ExampleFirstName,ExampleLastName")] Datamodel datamodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datamodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datamodel);
        }

        // GET: Datamodel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Datamodel datamodel = db.Datamodels.Find(id);
            if (datamodel == null)
            {
                return HttpNotFound();
            }
            return View(datamodel);
        }

        // POST: Datamodel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Datamodel datamodel = db.Datamodels.Find(id);
            db.Datamodels.Remove(datamodel);
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
