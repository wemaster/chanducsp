using Nhatngu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nhatngu.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            NewsDAO tbnew = new NewsDAO();
            ViewBag.viewdate = tbnew.GetviewDate();
            var model = tbnew.ViewListAll();
            return View(model);
        }
        [ChildActionOnly]
        public ActionResult CountNotif()
        {
            if (Session["NameUser"]!= null)
            {
                UserDAO us = new UserDAO();
                var model = us.GetIDuser(Session["NameUser"].ToString());
                return PartialView(model);
            }
            return PartialView();
            
        }
        [ChildActionOnly]
        public ActionResult MenuLeft()
        {
            CateParentDAO tbCateParent = new CateParentDAO();
            CateChildDAO tbCateChild = new CateChildDAO();
            var model = tbCateParent.Listcate();
            ViewBag.ViewChild = tbCateChild.ListChild();
            return PartialView(model);
        }
        [HttpGet]
        [ChildActionOnly]
        public ActionResult BoxChat()
        {
            return PartialView();
        }
        //[HttpPost]
        //public ActionResult BoxChat(string user)
        //{
        //    if (Session["NameUser"] == null)
        //    {
        //        return RedirectToAction("Index", "Login");
        //    }
        //    return RedirectToAction("Index", "Home");
        //}
        [ChildActionOnly]
        public ActionResult BoxKanji()
        {
            KanjiDAO tbkanji= new KanjiDAO();
            var model = tbkanji.ViewKanji();
            return PartialView(model);
        }
        [ChildActionOnly]
        public ActionResult BoxTopView()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult RowTopRank()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult RowTotalWeb()
        {
            return PartialView();
        }
	}
}