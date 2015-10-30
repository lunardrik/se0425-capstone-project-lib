using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using LIB;
using LIBWeb.Models;

namespace LIBWeb.Controllers
{

    [HandleError]
    public class AccountController : Controller
    {

        public IFormsAuthenticationService FormsService { get; set; }
        public IMembershipService MembershipService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null) { FormsService = new FormsAuthenticationService(); }
            if (MembershipService == null) { MembershipService = new AccountMembershipService(); }

            base.Initialize(requestContext);
        }

        // **************************************
        // URL: /Account/LogOn
        // **************************************

        public ActionResult LogOn()
        {
            if (Session["USER"] == null)
            {
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            UserBUS bus = new UserBUS();
            var user = bus.GetUserById(model.UserName.ToLower());

            if (user != null && user.Password.Equals(model.Password))
            {
                Session.Add("USER", user);
                Log.Info("User Logged In");
                if (!String.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ViewData.Add("LogOnError", "Tên đăng nhập không tồn tại hoặc mật khẩu bị sai. Xin vui lòng kiểm tra lại!");
            }
            // If we got this far, something failed, redisplay form
            return View(model);
        }

        // **************************************
        // URL: /Account/LogOff
        // **************************************

        public ActionResult LogOff()
        {
            //FormsService.SignOut();
            Session.Remove("USER");
            Log.Info("User Logged Out");
            return RedirectToAction("Index", "Home");
        }

        // **************************************
        // URL: /Account/Register
        // **************************************

        public ActionResult Register()
        {
            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                MembershipCreateStatus createStatus = MembershipService.CreateUser(model.UserName, model.Password, model.Email);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    FormsService.SignIn(model.UserName, false /* createPersistentCookie */);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", AccountValidation.ErrorCodeToString(createStatus));
                }
            }

            // If we got this far, something failed, redisplay form
            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;
            return View(model);
        }

        // **************************************
        // URL: /Account/ChangePassword
        // **************************************

        public ActionResult ChangePassword()
        {
            if (Session["USER"] != null)
            {
                ViewData["RESULT"] = "-1";
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult ChangePassword(FormCollection collection)
        {
            if (Session["USER"] != null)
            {
                UserBUS bus = new UserBUS();
                UserDTO user = (UserDTO)Session["USER"];
                string oldPass = collection["txtOldPassword"];
                string newPass = collection["txtNewPassword"];


                if (!user.Password.Equals(oldPass))
                {
                    ViewData["RESULT"] = "0";
                    return View();
                }
                else
                {
                    Feature f = new Feature();
                    ViewData["RESULT"] = f.ChangePassword(user, newPass) ? "1" : "0";

                    return View();
                }
            }

            return RedirectToAction("Index", "Home");
        }

        // **************************************
        // URL: /Account/ChangePasswordSuccess
        // **************************************

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }


        public ActionResult Information()
        {
            if (Session["USER"] != null)
            {
                Log.Info("View detail information");
                return View(Session["USER"]);
            }
            
            return RedirectToAction("Index", "Home");
        }

        public ActionResult ResetPassword()
        {
            ViewData["RESULT"] = "-1";
            return View();
        }

        [HttpPost]
        public ActionResult ResetPassword(FormCollection collection)
        {
            UserBUS bus = new UserBUS();
            UserDTO user = bus.GetUserById(collection["txtUserId"]);

            if (user == null)
            {
                ViewData["RESULT"] = "0";
            }
            else
            {
                ViewData["RESULT"] = "1";
                Feature f = new Feature();
                f.ResetPassword(user);
            }
            return View();
        }
    }
}
