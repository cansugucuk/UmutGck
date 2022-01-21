﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibraryApplication.DbModel.Context;
using LibraryApplication.DbModel.Entity;

namespace LibraryApplication.Controllers
{
    public class StudentsController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: Students
        public ActionResult Index()
        {
            var students = db.Students.Include(s => s.Country).Include(s => s.UserType);
            return View(students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Countrys, "Id", "Name");
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Name");
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Surname,PhoneNumber,Email,GradeNumber,Documents,Photo,Username,Password,Birthdate,CountryId,IsBlocked,ReasonBlocked,CreatedDate,IsActive,UserTypeId")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(db.Countrys, "Id", "Name", student.CountryId);
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Name", student.UserTypeId);
            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.CountryId = new SelectList(db.Countrys, "Id", "Name", student.CountryId);
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Name", student.UserTypeId);
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Surname,PhoneNumber,Email,GradeNumber,Documents,Photo,Username,Password,Birthdate,CountryId,IsBlocked,ReasonBlocked,CreatedDate,IsActive,UserTypeId")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CountryId = new SelectList(db.Countrys, "Id", "Name", student.CountryId);
            ViewBag.UserTypeId = new SelectList(db.UserTypes, "Id", "Name", student.UserTypeId);
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
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
