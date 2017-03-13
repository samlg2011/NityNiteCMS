using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessEntities;
using BusinessLayer;
using DataAccessLayer;
using ViewModel;

namespace NityNiteCMSBootstrap.Controllers
{
    public class HomeController : Controller
    {
        private ContentBussinessLayer contentBL = new ContentBussinessLayer();
        private CMSDBDAL cmsDal = new CMSDBDAL();
        public ActionResult Index()
        {
            if (contentBL.CheckExistPage("Index"))
            {
                return View("Index", contentBL.FindPage("Index"));
            }
            else
            {
                return new EmptyResult();
            }
        }
        public ActionResult About()
        {
            if(contentBL.CheckExistPage("About"))
            {
                return View("About", contentBL.FindPage("About"));
            }else
            {
                return new EmptyResult();
            }
        }

        public ActionResult Contact()
        {
            if (contentBL.CheckExistPage("Contact"))
            {
                return View("Contact", contentBL.FindPage("Contact"));
            }
            else
            {
                return new EmptyResult();
            }
        }
        public ActionResult Blog()
        {
            return View();
        }
    }
}