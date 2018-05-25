using Nhatngu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nhatngu.Controllers
{
    public class TestController : Controller
    {
        public const string ListCheck = "SessionListCheck"; 
        //
        // GET: /Test/
        [HttpGet]
        public ActionResult Index(int Id)
        {
            var listitem = Session[ListCheck];
            TestDAO tblViewtest = new TestDAO();
            var item = new List<ItemDAO>();
            if (listitem != null)
            {
                item = (List<ItemDAO>)listitem;
            }
            var model = tblViewtest.ListTest(Id);
            ViewBag.listcheckitem = item;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ModelTblTest model, int Id)
        {
            TestDAO tblTestModel = new TestDAO();
            var TestTrue = tblTestModel.ListTestTrue(model.IDTest);
            if (ModelState.IsValid)
            {
                if (model.Ischecked1)
                {
                    string Correct = "A";
                    if (Correct == TestTrue.TestTrue)
                    {
                        CheckItemTrue(model);
                    }
                    else
                    {
                        CheckItemFalse(model);
                    }
                }
                else if (!!model.Ischecked2)
                {
                    string Correct = "B";
                    if (Correct == TestTrue.TestTrue)
                    {
                        CheckItemTrue(model);
                    }
                    else
                    {
                        CheckItemFalse(model);
                    }
                }
                else if (!!model.Ischecked3)
                {
                    string Correct = "C";
                    if (Correct == TestTrue.TestTrue)
                    {
                        CheckItemTrue(model);
                    }
                    else
                    {
                        CheckItemFalse(model);
                    }
                }
                else if (!!model.Ischecked4)
                {
                    string Correct = "D";
                    if (Correct == TestTrue.TestTrue)
                    {
                        CheckItemTrue(model);
                    }
                    else
                    {
                        CheckItemFalse(model);
                    }
                }
            }
            return View();
        }
        public void CheckItemTrue(ModelTblTest model)
        {
            var SessionItem = Session[ListCheck];
            var list = (List<ItemDAO>)SessionItem;
            //Them moi session
           
            if (list != null)
            {
                var item = new ItemDAO();
                TestDAO tblTestModel = new TestDAO();
                var TestcheckTrue = tblTestModel.ListTestTrue(model.IDTest);
                item.Img = "~/Assets/dist/img/yes.png";
                item.TestTrue = TestcheckTrue.TestTrue;
                item.CountTotal = item.CountTotal + 1;
                list.Add(item);
                Session[ListCheck] = list;
            }
            else
            {
               list = new List<ItemDAO>();
               var item = new ItemDAO();
               TestDAO tblTestModel = new TestDAO();
               var TestcheckTrue = tblTestModel.ListTestTrue(model.IDTest);
               item.Img = "~/Assets/dist/img/yes.png";
               item.TestTrue = TestcheckTrue.TestTrue;
               item.CountTotal = item.CountTotal + 1;
               list.Add(item);
               Session[ListCheck] = list;
            }

        }
        public void CheckItemFalse(ModelTblTest model)
        {
            var SessionItem = Session[ListCheck];
            var list = (List<ItemDAO>)SessionItem;
            //Them moi session
            if (list!= null)
            {
                var item = new ItemDAO();
                TestDAO tblTestModel = new TestDAO();
                var TestcheckTrue = tblTestModel.ListTestTrue(model.IDTest);
                item.Img = "~/Assets/dist/img/False.png";
                item.TestTrue = TestcheckTrue.TestTrue;
                list.Add(item);
                Session[ListCheck] = list;
            }
            else
            {
                list = new List<ItemDAO>();
                var item = new ItemDAO();
                TestDAO tblTestModel = new TestDAO();
                var TestcheckTrue = tblTestModel.ListTestTrue(model.IDTest);
                item.Img = "~/Assets/dist/img/False.png";
                item.TestTrue = TestcheckTrue.TestTrue;
                list.Add(item);
                Session[ListCheck] = list;
            }
            

        }
    }
}