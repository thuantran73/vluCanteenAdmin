using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using vluCanteenAdmin.Models;

namespace vluCanteenAdmin.Controllers
{
    public class FoodController : Controller
    {
        private SEP23Team9Entities db = new SEP23Team9Entities();

        // GET: Food
        public ActionResult Index()
        {
            var food1 = db.Food1.Include(f => f.Category);
            return View(food1.ToList());
        }

        // GET: Food/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food1 food1 = db.Food1.Find(id);
            if (food1 == null)
            {
                return HttpNotFound();
            }
            return View(food1);
        }

        // GET: Food/Create
        public ActionResult Create()
        {
            ViewBag.Category_ID = new SelectList(db.Categories, "Category_ID", "Category_Name");
            return View();
        }

        // POST: Food/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Food_ID,Name,Category_ID,Discount,Price,Remain,Description,Image,isToday,Status")] Food1 food1)
        {
            if (ModelState.IsValid)
            {
                db.Food1.Add(food1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Category_ID = new SelectList(db.Categories, "Category_ID", "Category_Name", food1.Category_ID);
            return View(food1);
        }

        // GET: Food/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food1 food1 = db.Food1.Find(id);
            if (food1 == null)
            {
                return HttpNotFound();
            }
            ViewBag.Category_ID = new SelectList(db.Categories, "Category_ID", "Category_Name", food1.Category_ID);
            return View(food1);
        }

        // POST: Food/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Food_ID,Name,Category_ID,Discount,Price,Remain,Description,Image,isToday,Status")] Food1 food1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(food1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Category_ID = new SelectList(db.Categories, "Category_ID", "Category_Name", food1.Category_ID);
            return View(food1);
        }

        // GET: Food/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food1 food1 = db.Food1.Find(id);
            if (food1 == null)
            {
                return HttpNotFound();
            }
            return View(food1);
        }

        // POST: Food/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Food1 food1 = db.Food1.Find(id);
            db.Food1.Remove(food1);
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
