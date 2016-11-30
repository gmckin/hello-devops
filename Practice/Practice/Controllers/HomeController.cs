using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
  public class HomeController : Controller
  {
    // GET: Home
    public ActionResult Index()
    {
      return View();
    }

    public JsonResult GetProducts()
    {
      var db = new ProductsDBEntities();
      var products = db.Products.ToList();
      return Json(products, JsonRequestBehavior.AllowGet);
    }
  }
}