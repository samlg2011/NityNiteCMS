using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessEntities;
using BusinessLayer;
using System.Web.Security;
using ViewModel;

namespace NityNiteCMS.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DoLogin(LoginViewModel user)
        {
            AuthBusinessLayer abLayer = new AuthBusinessLayer();
            Auth loginUser = new Auth();
            loginUser = abLayer.FindUser(user.UserName);
            if(abLayer.IsValidUser(loginUser))
            {
                FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
                return RedirectToAction("Index", "Contents");
            }
            else
            {
                ModelState.AddModelError("CredentialError", "Invalid Username or Password");
                return View("Login");
            }
        }
    }
}