using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibraryApplication.Concrete.Repositories;
using LibraryApplication.DbModel.Entity;
using LibraryApplication.Models;

namespace LibraryApplication.Controllers
{
    public class BorrowsController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: Borrows
        public ActionResult Index()
        {
            var borrows = db.Borrows.Include(b => b.Book).Include(b => b.User);

            return View(borrows.ToList());
        }

        // GET: Borrows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Borrow borrow = db.Borrows.Find(id);

            var borrowVm = new BorrowViewModel();
            borrowVm.Id = borrow.Id;
            borrowVm.UserId = borrow.UserId;
            borrowVm.BookId = borrow.BookId;
            borrowVm.StartingDate = borrow.StartingDate;
            borrowVm.EndDate = borrow.EndDate;
            borrowVm.Book = borrow.Book;
            borrowVm.User = borrow.User;


            if (borrowVm == null)
            {
                return HttpNotFound();
            }
            return View(borrowVm);
        }

        // GET: Borrows/Create
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(db.Books, "Id", "BookName");
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName");
            return View();
        }

        // POST: Borrows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,BookId,StartingDate,EndDate")] Borrow borrow)
        {
            if (ModelState.IsValid)
            {
                db.Borrows.Add(borrow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookId = new SelectList(db.Books, "Id", "BookName", borrow.BookId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", borrow.UserId);

            var borrowVm = new BorrowViewModel();
            borrowVm.Id = borrow.Id;
            borrowVm.UserId = borrow.UserId;
            borrowVm.BookId = borrow.BookId;
            borrowVm.StartingDate = borrow.StartingDate;
            borrowVm.EndDate = borrow.EndDate;
            borrowVm.Book = borrow.Book;
            borrowVm.User = borrow.User;

            return View(borrowVm);
        }

        // GET: Borrows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Borrow borrow = db.Borrows.Find(id);
            if (borrow == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "BookName", borrow.BookId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", borrow.UserId);

            var borrowVm = new BorrowViewModel();
            borrowVm.Id = borrow.Id;
            borrowVm.UserId = borrow.UserId;
            borrowVm.BookId = borrow.BookId;
            borrowVm.StartingDate = borrow.StartingDate;
            borrowVm.EndDate = borrow.EndDate;
            borrowVm.Book = borrow.Book;
            borrowVm.User = borrow.User;

            return View(borrowVm);
        }

        // POST: Borrows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,BookId,StartingDate,EndDate")] Borrow borrow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(borrow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "BookName", borrow.BookId);
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserName", borrow.UserId);

            var borrowVm = new BorrowViewModel();
            borrowVm.Id = borrow.Id;
            borrowVm.UserId = borrow.UserId;
            borrowVm.BookId = borrow.BookId;
            borrowVm.StartingDate = borrow.StartingDate;
            borrowVm.EndDate = borrow.EndDate;
            borrowVm.Book = borrow.Book;
            borrowVm.User = borrow.User;

            return View(borrowVm);
        }

        // GET: Borrows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Borrow borrow = db.Borrows.Find(id);

            var borrowVm = new BorrowViewModel();
            borrowVm.Id = borrow.Id;
            borrowVm.UserId = borrow.UserId;
            borrowVm.BookId = borrow.BookId;
            borrowVm.StartingDate = borrow.StartingDate;
            borrowVm.EndDate = borrow.EndDate;
            borrowVm.Book = borrow.Book;
            borrowVm.User = borrow.User;

            if (borrowVm == null)
            {
                return HttpNotFound();
            }
            return View(borrowVm);
        }

        // POST: Borrows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Borrow borrow = db.Borrows.Find(id);
            db.Borrows.Remove(borrow);
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
