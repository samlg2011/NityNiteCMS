using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using BusinessEntities;
using DataAccessLayer;
using ViewModel;

namespace NityNiteCMS.Controllers
{
    public class ContentsController : Controller
    {
        private CMSDBDAL db = new CMSDBDAL();
        ContentBussinessLayer contentBL = new ContentBussinessLayer();

        // GET: Contents
        public ActionResult Index()
        {
            return View("Index", contentBL.GetPage());
        }

        // GET: Contents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Content content = contentBL.FindPage(id);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // GET: Contents/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PageId,PageName,PageTitle,PageSubTitle,PageLevel,PageContent1Title,PageContent1,PageContent2Title,PageContent2,PageContent3Title,PageContent3")] Content content)
        {
            if (ModelState.IsValid)
            {
                contentBL.CreatePage(content);
                return RedirectToAction("Index");
            }

            return View(content);
        }

        // GET: Contents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Content content = contentBL.FindPage(id);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PageId,PageName,PageTitle,PageSubTitle,PageLevel,PageContent1Title,PageContent1,PageContent2Title,PageContent2,PageContent3Title,PageContent3")] Content content)
        {
            if (ModelState.IsValid)
            {
                contentBL.EditPage(content);
                return RedirectToAction("Index");
            }
            return View(content);
        }

        // GET: Contents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Content content = contentBL.FindPage(id);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // POST: Contents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            contentBL.DeletePage(id);
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
