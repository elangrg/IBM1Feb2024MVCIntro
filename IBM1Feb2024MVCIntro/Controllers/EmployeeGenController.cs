using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IBM1Feb2024MVCIntro.Models;

namespace IBM1Feb2024MVCIntro.Controllers
{
    public class EmployeeGenController : Controller
    {
        private IBM25Jan24DbEntities db = new IBM25Jan24DbEntities();

        // GET: EmployeeGen
        public ActionResult Index()
        {
            return View(db.EmployeeDepts.ToList());
        }

        // GET: EmployeeGen/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDept employeeDept = db.EmployeeDepts.Find(id);
            if (employeeDept == null)
            {
                return HttpNotFound();
            }
            return View(employeeDept);
        }

        // GET: EmployeeGen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeGen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( EmployeeDept employeeDept)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeDepts.Add(employeeDept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeDept);
        }

        // GET: EmployeeGen/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDept employeeDept = db.EmployeeDepts.Find(id);
            if (employeeDept == null)
            {
                return HttpNotFound();
            }
            return View(employeeDept);
        }

        // POST: EmployeeGen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,EmpName,Salary,DeptName")] EmployeeDept employeeDept)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeDept).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeDept);
        }

        // GET: EmployeeGen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDept employeeDept = db.EmployeeDepts.Find(id);
            if (employeeDept == null)
            {
                return HttpNotFound();
            }
            return View(employeeDept);
        }

        // POST: EmployeeGen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeDept employeeDept = db.EmployeeDepts.Find(id);
            db.EmployeeDepts.Remove(employeeDept);
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
