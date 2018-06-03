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
        private ProductService _service = new ProductService();
        private Common _common = new Common();
        #endregion

        public ActionResult Index()
        {
            List<ProductDto> Verhicle = new List<ProductDto>();
            Verhicle = _service.GetAllProduct("01");
            List<ProductDto> Category = new List<ProductDto>();
            Category = _service.GetAllProduct("02");
            foreach (var item in Verhicle)
            {
                item.Image1 = _common.ChangePathImage(item.Image1);
            }
            foreach (var item in Category)
            {
                item.Image1 = _common.ChangePathImage(item.Image1);
            }
            ViewBag.Verhicle = Verhicle;
            ViewBag.VerhicleCount = Verhicle.Count();
            ViewBag.Category = Category;
            ViewBag.CategoryCount = Category.Count();
            return View(ViewBag);
        }      
    }

   
}