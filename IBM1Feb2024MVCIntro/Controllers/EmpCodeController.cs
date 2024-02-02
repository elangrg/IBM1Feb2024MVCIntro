using IBM1Feb2024MVCIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IBM1Feb2024MVCIntro.Controllers
{
    public class EmpCodeController : Controller
    {
        Models.IBM25Jan24DbEntities _db = new Models.IBM25Jan24DbEntities();



        // GET: EmpCode
        public ActionResult Index()
        {
            return View(_db.EmployeeDepts.ToList());
        }

        // GET: EmpCode/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpCode/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpCode/Create
        [HttpPost]
        public ActionResult Create(EmployeeDept  emp)
        {
            try
            {


                _db.EmployeeDepts.Add(emp);
                _db.SaveChanges();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View(emp);
            }
        }

        // GET: EmpCode/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_db.EmployeeDepts.Find(id));
        }

        // POST: EmpCode/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmployeeDept emp)
        {
            try
            {
                if (id != emp.EmployeeID) { return HttpNotFound(); }

                _db.Entry(emp).State= System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpCode/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpCode/Delete/5
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
