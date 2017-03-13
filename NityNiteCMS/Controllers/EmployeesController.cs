using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessEntities;
using DataAccessLayer;
using BusinessLayer;
using ViewModel;

namespace NityNiteCMS.Controllers
{
    public class EmployeesController : Controller
    {
        private CMSDBDAL db = new CMSDBDAL();
        private EmployeeViewModel empVM = new EmployeeViewModel();
        private EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();

        // GET: Employees
        public ActionResult Index()
        {
            return View("Index", empVM.GetEmployeeViewModelList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = empBL.FindEmployee(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeId,FirstName,LastName,SIN,EmployeeType,EmployeeStartDate,EmployeeEndDate,EmployeePhone,EmployeeMobile,EmployeeStreetNum,EmployeeStreetName,EmployeeProvince,EmployeePostCode,EmployeeSalary")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                empBL.CreateEmployee(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = empBL.FindEmployee(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeId,FirstName,LastName,SIN,EmployeeType,EmployeeStartDate,EmployeeEndDate,EmployeePhone,EmployeeMobile,EmployeeStreetNum,EmployeeStreetName,EmployeeProvince,EmployeePostCode,EmployeeSalary")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                empBL.EditEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = empBL.FindEmployee(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            empBL.DeleteEmployee(id);
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
