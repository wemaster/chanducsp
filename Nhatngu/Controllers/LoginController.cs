using Nhatngu.code;
using Nhatngu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Nhatngu.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        [HttpGet]
        public ActionResult Index()
        {
            UserDAO us = new UserDAO();
            if (Session["NameUser"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Index(TblAcc tableAcc)
        {
            if (ModelState.IsValid)
            {
                UserDAO user = new UserDAO();
                var pwd = md5Pwd.MD5Hash(tableAcc.PassAcc);
                var result = user.loginuser(tableAcc.NameAcc,pwd);
                if (result == 1)
                {
                    Session["IdUser"] = tableAcc.IdAcc;
                    Session["NameUser"] = tableAcc.NameAcc;
                    return RedirectToAction("Index","Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("error","Tài khoản không tồn tại,vui lòng kiểm tra lại");
                }
                else if(result == -1)
                {
                    ModelState.AddModelError("error", "Mật khẩu không đúng");
                }
            }
            else
            {
                ModelState.AddModelError("error", "Đăng nhập không thành công. Lỗi #100");
            }
            return View("Index");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
	}
}