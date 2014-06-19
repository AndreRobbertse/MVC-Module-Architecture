using MVC.Module.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Module.Test.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        //public ActionResult Index()
        //{
        //    List<TestModel> model = new List<TestModel>();
        //    model.Add(new TestModel { Name = "Koos", Created = DateTime.Now });
        //    model.Add(new TestModel { Name = "Jan", Created = DateTime.Now });
        //    model.Add(new TestModel { Name = "Bob", Created = DateTime.Now });

        //    return View(model);
        //}


        public ActionResult Index()
        {
            return View();
        }

    }
}
