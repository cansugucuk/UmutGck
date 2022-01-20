using System;
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
    public class TeacherLessonsController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: TeacherLessons
        public ActionResult Index()
        {
            var teacherLessons = db.TeacherLessons.Include(t => t.Lesson).Include(t => t.Teacher);
            return View(teacherLessons.ToList());
        }

        // GET: TeacherLessons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherLesson teacherLesson = db.TeacherLessons.Find(id);
            if (teacherLesson == null)
            {
                return HttpNotFound();
            }
            return View(teacherLesson);
        }

        // GET: TeacherLessons/Create
        public ActionResult Create()
        {
            ViewBag.LessonId = new SelectList(db.Lessons, "Id", "Name");
            ViewBag.TeacherId = new SelectList(db.Teachers, "Id", "Name");
            return View();
        }

        // POST: TeacherLessons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TeacherId,LessonId,CreatedDate")] TeacherLesson teacherLesson)
        {
            if (ModelState.IsValid)
            {
                db.TeacherLessons.Add(teacherLesson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LessonId = new SelectList(db.Lessons, "Id", "Name", teacherLesson.LessonId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "Id", "Name", teacherLesson.TeacherId);
            return View(teacherLesson);
        }

        // GET: TeacherLessons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherLesson teacherLesson = db.TeacherLessons.Find(id);
            if (teacherLesson == null)
            {
                return HttpNotFound();
            }
            ViewBag.LessonId = new SelectList(db.Lessons, "Id", "Name", teacherLesson.LessonId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "Id", "Name", teacherLesson.TeacherId);
            return View(teacherLesson);
        }

        // POST: TeacherLessons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TeacherId,LessonId,CreatedDate")] TeacherLesson teacherLesson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacherLesson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LessonId = new SelectList(db.Lessons, "Id", "Name", teacherLesson.LessonId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "Id", "Name", teacherLesson.TeacherId);
            return View(teacherLesson);
        }

        // GET: TeacherLessons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherLesson teacherLesson = db.TeacherLessons.Find(id);
            if (teacherLesson == null)
            {
                return HttpNotFound();
            }
            return View(teacherLesson);
        }

        // POST: TeacherLessons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeacherLesson teacherLesson = db.TeacherLessons.Find(id);
            db.TeacherLessons.Remove(teacherLesson);
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
