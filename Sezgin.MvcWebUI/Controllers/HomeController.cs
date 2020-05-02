using Sezgin.Bll.Concrete;
using Sezgin.Dal.Concrete.EntityFramework;
using Sezgin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sezgin.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            List<Product> products = productManager.GetAll();  
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}