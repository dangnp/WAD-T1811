using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestFAIC.Context;
using TestFAIC.Models;

namespace TestFAIC.Controllers
{
    public class CategoryController : Controller
    {
        eContext db = new eContext();
        // GET: Category
        public ActionResult Index()
        {
            return View(db.Categorys.ToList());
        }

        // GET: Category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Category category = db.Categorys.Find(id);
            if (category == null)
                return HttpNotFound();
            return View(category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
           
                return View();
            
            
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.Categorys.Add(category);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(category);
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categorys.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    db.Entry(category).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
                return View(category);
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Category category = db.Categorys.Find(id);
            if (category == null)
                return HttpNotFound();
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Category cate)
        {
            try
            {
                Category category = new Category();
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    category = db.Categorys.Find(id);
                    if (category == null)
                        return HttpNotFound();
                    db.Categorys.Remove(category);
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
                return View(category);
            }
            catch
            {
                return View();
            }
        }
    }
}
