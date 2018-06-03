using Data.Dtos;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    public class HomeController : Controller
    {
        #region contructor
        private ProductService service = new ProductService();
       
        #endregion

        public ActionResult Index()
        {
            List<ProductDto> Verhicle = new List<ProductDto>();
            Verhicle = service.GetAllProduct("01");
            List<ProductDto> Category = new List<ProductDto>();
            Category = service.GetTopCategory(10);
            ViewBag.Verhicle = Verhicle;
            ViewBag.Category = Category;
            return View(ViewBag);
        }      
    }

   
}