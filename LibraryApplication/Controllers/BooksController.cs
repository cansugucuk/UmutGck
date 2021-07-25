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
    public class BooksController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: Books
        public ActionResult Index()
        {
            var books = db.Books.Include(b => b.Author).Include(b => b.Category);
            return View(books.ToList());
        }

        // GET: Books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            var bookVm = new BookViewModel();
            bookVm.Id = book.Id;
            bookVm.CategoryId = book.CategoryId;
            bookVm.AuthorId = book.AuthorId;
            bookVm.BookName = book.BookName;      
            bookVm.PageNumber = book.PageNumber;
            bookVm.ShelfNumber = book.ShelfNumber;
            bookVm.Category = book.Category;
            bookVm.Author = book.Author;


            if (bookVm == null)
            {
                return HttpNotFound();
            }
            return View(bookVm);
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "FirstName");
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CategoryId,AuthorId,BookName,ShelfNumber,PageNumber")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "FirstName", book.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", book.CategoryId);
            var bookVm = new BookViewModel();
            bookVm.Id = book.Id;
            bookVm.CategoryId = book.CategoryId;
            bookVm.AuthorId = book.AuthorId;
            bookVm.BookName = book.BookName;
            bookVm.PageNumber = book.PageNumber;
            bookVm.ShelfNumber = book.ShelfNumber;
            bookVm.Category = book.Category;
            bookVm.Author = book.Author;

            return View(bookVm);
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            var bookVm = new BookViewModel();
            bookVm.Id = book.Id;
            bookVm.CategoryId = book.CategoryId;
            bookVm.AuthorId = book.AuthorId;
            bookVm.BookName = book.BookName;
            bookVm.PageNumber = book.PageNumber;
            bookVm.ShelfNumber = book.ShelfNumber;
            bookVm.Category = book.Category;
            bookVm.Author = book.Author;

            if (bookVm == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "FirstName", book.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", book.CategoryId);
            return View(bookVm);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CategoryId,AuthorId,BookName,ShelfNumber,PageNumber")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(db.Authors, "Id", "FirstName", book.AuthorId);
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", book.CategoryId);

            var bookVm = new BookViewModel();
            bookVm.Id = book.Id;
            bookVm.CategoryId = book.CategoryId;
            bookVm.AuthorId = book.AuthorId;
            bookVm.BookName = book.BookName;
            bookVm.PageNumber = book.PageNumber;
            bookVm.ShelfNumber = book.ShelfNumber;
            bookVm.Category = book.Category;
            bookVm.Author = book.Author;

            return View(bookVm);
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);

            var bookVm = new BookViewModel();
            bookVm.Id = book.Id;
            bookVm.CategoryId = book.CategoryId;
            bookVm.AuthorId = book.AuthorId;
            bookVm.BookName = book.BookName;
            bookVm.PageNumber = book.PageNumber;
            bookVm.ShelfNumber = book.ShelfNumber;
            bookVm.Category = book.Category;
            bookVm.Author = book.Author;


            if (bookVm == null)
            {
                return HttpNotFound();
            }
            return View(bookVm);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
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
