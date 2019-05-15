using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hanamiSushiBar.Models;
using System.Data.Entity;

namespace hanamiSushiBar.Controllers
{
    public class HomeController : Controller
    {
        private sushiBarEntities db = new sushiBarEntities();

        public ActionResult Index()
        {
            var products = db.product.Include(prod => prod.categories);
            return View(products.ToList());
        }
        
        
    }
}