using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using RentThings.Interfaces;
using RentThings.Models.Tag;
using RentThings.Services;
using LightInject;

namespace RentThings.Controllers
{
    public class AccountController : Controller
    {
        public EntityAccountService _accountService;

        public AccountController(EntityAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet]
        public ActionResult Login()
        {
            LoginTag loginModel = new LoginTag();

            return View(loginModel);
        }
        [HttpPost]
        public ActionResult Login(LoginTag loginModel)
        {
            if (ModelState.IsValid)
            {

                if (_accountService.VerifyUserByLoginAndPassword(loginModel))
                {
                    FormsAuthentication.SignOut();
                    FormsAuthentication.SetAuthCookie(loginModel.Login,true);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}