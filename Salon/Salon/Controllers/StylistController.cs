﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Salon.DAL;
using Salon.Models;

namespace Salon.Controllers
{
    public class StylistController : Controller
    {
        private SalonContext db = new SalonContext();

        // GET: Stylist
        public ActionResult Index()
        {
            return View(db.Stylists.ToList());
        }

        // GET: Stylist/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stylist stylist = db.Stylists.Find(id);
            if (stylist == null)
            {
                return HttpNotFound();
            }
            return View(stylist);
        }

        // GET: Stylist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stylist/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StylistId,FirstName,LastName")] Stylist stylist)
        {
            if (ModelState.IsValid)
            {
                db.Stylists.Add(stylist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stylist);
        }

        // GET: Stylist/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stylist stylist = db.Stylists.Find(id);
            if (stylist == null)
            {
                return HttpNotFound();
            }
            return View(stylist);
        }

        // POST: Stylist/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StylistId,FirstName,LastName")] Stylist stylist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stylist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stylist);
        }

        // GET: Stylist/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stylist stylist = db.Stylists.Find(id);
            if (stylist == null)
            {
                return HttpNotFound();
            }
            return View(stylist);
        }

        // POST: Stylist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stylist stylist = db.Stylists.Find(id);
            db.Stylists.Remove(stylist);
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
