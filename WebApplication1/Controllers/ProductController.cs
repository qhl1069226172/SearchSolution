using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    using Models;
    public class ProductController : Controller
    {
        ProductDBContext productDBContext = new ProductDBContext();
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.clothSize= productDBContext.ClothSizes; 
            ViewBag.clothColor = productDBContext.ColthColors;
            ViewBag.clothType = productDBContext.ColthTypes;
            ViewBag.priceRamdoms = productDBContext.PriceRamdoms;
            //ViewBag.products = productDBContext.Products;
            return View();
        }
    }
}