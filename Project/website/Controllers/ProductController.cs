using Data.Dtos;
using Data.Infrastructure;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    public class ProductController : Controller
    {
        #region contructor
        private ProductService _service = new ProductService();
        private Common _common = new Common();
        
        #endregion


        // GET: Verhicle
        public ActionResult Verhicle()
        {
            List<ProductDto> ls = new List<ProductDto>();
            ls = _service.GetAllProduct(Constant.TYPE_VEHICLE);
            foreach (var item in ls)
            {
                item.Image1 = _common.ChangePathImage(item.Image1);
                if(item.Image2 != null)
                item.Image2 = _common.ChangePathImage(item.Image2);
                if (item.Image3 != null)
                    item.Image3 = _common.ChangePathImage(item.Image3);
                if (item.Image4 != null)
                    item.Image4 = _common.ChangePathImage(item.Image4);
                if (item.Image5 != null)
                    item.Image5 = _common.ChangePathImage(item.Image5);
            }
            int count = ls.Count();
            ViewBag.lsVerhicle = ls;
            ViewBag.countVerhicle = count;
            return View(ViewBag);
        }

        public ActionResult Category()
        {
            List<ProductDto> ls = new List<ProductDto>();
            ls = _service.GetAllProduct(Constant.TYPE_ACCESSORY);
            foreach (var item in ls)
            {
                item.Image1 = _common.ChangePathImage(item.Image1);
            }
            int count = ls.Count();
            ViewBag.lsCategory = ls;
            ViewBag.countCategory = count;
            return View(ViewBag);
        }
        public ActionResult Order()
        {
            return View();
        }
       
        public ActionResult VerhicleDetail(int id)
        {
            ProductDto Product = new ProductDto();
            Product = _service.GetProductByID(id, Constant.TYPE_VEHICLE);
            Product.Image1 = _common.ChangePathImage(Product.Image1);
            if (Product.Image2 != null) Product.Image2 = _common.ChangePathImage(Product.Image2);
            if (Product.Image3 != null) Product.Image3 = _common.ChangePathImage(Product.Image3);
            if (Product.Image4 != null) Product.Image4 = _common.ChangePathImage(Product.Image4);
            if (Product.Image5 != null) Product.Image5 = _common.ChangePathImage(Product.Image5);
            ViewBag.VerhicleDetail = Product;
            return View(ViewBag);
        }

        //CategoryDetail
        public ActionResult CategoryDetail(int id)
        {
            ProductDto Product = new ProductDto();
            Product = _service.GetProductByID(id, Constant.TYPE_ACCESSORY);
            Product.Image1 = _common.ChangePathImage(Product.Image1);       
            ViewBag.CategoryDetail = Product;
            return View(ViewBag);
        }
    }
}