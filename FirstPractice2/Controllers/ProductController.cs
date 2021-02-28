using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstPractice2.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Web.Script.Serialization;

namespace FirstPractice2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [HttpGet]
        public ActionResult Index(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts(id);
            return View(Products);
        }
        [HttpGet]
        public ActionResult Index1(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts11(id);
            return View(Products);
        }
        [HttpGet]
        public ActionResult Index2(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts21(id);
            return View(Products);
        }
        [HttpGet]
        public ActionResult Index3(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts31(id);
            return View(Products);
        }
        [HttpGet]
        public ActionResult Index4(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts41(id);
            return View(Products);
        }
        [HttpGet]
        public ActionResult Index5(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts51(id);
            return View(Products);
        }
        [HttpGet]
        public ActionResult Index6(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts51(id);
            return Json(Products, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Filter(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts51(id);
            return View(Products);
        }
        [HttpGet]
        public ActionResult Index7(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts52(id);
            return Json(Products, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Index8(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts53(id);
            return Json(Products, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Index9(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts54(id);
            return Json(Products, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Index10(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts55(id);
            return Json(Products, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Index11(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts56(id);
            return Json(Products, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Index12(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts57(id);
            return Json(Products, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Index13(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts58(id);
            return Json(Products, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Index14(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.LoadProducts59(id);
            return Json(Products, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            Product _product = ProductDataContext.LoadProductByID(id);
            return View(_product);

        }

        [HttpPost]
        public ActionResult Edit()
        {

            Product _product = new Product();
            _product.ProductID = Convert.ToInt32(Request.Form["ProductID"]);
            _product.ProductName = Request.Form["ProductName"];
            _product.SupplierID = Convert.ToInt32(Request.Form["SupplierID"]);
            _product.CategoryID = Convert.ToInt32(Request.Form["CategoryID"]);
            _product.QuantityPerUnit = Request.Form["QuantityPerUnit"];
            _product.UnitPrice = Convert.ToDecimal(Request.Form["UnitPrice"]);
            _product.UnitsInStock = Convert.ToInt16(Request.Form["UnitsInStock"]);
            _product.UnitsOnOrder = Convert.ToInt16(Request.Form["UnitsOnOrder"]);
            ProductDataContext.EditProduct(_product);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Delete(int id = 0)
        {
            ProductDataContext.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Search(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> products = ProductDataContext.LoadProducts1(id);
            return View(products);
        }

        [HttpGet]
        public ActionResult Insert(int id = 0)
        {
            List<Product> products = ProductDataContext.InsertProducts2(id);
            return View(products);
        }

        [HttpPost]
        public ActionResult Insert()
        {
            if (Request.Form.Count > 0)
            {
                Product _product = new Product();
                _product.CategoryID = Convert.ToInt32(Request.Form["CategoryID"]);
                _product.SupplierID = Convert.ToInt32(Request.Form["SupplierID"]);
                _product.CategoryName = Request.Form["CategoryName"];
                _product.CompanyName = Request.Form["CompanyName"];
                _product.ProductName = Request.Form["ProductName"];
                _product.QuantityPerUnit = Request.Form["QuantityPerUnit"];
                _product.UnitPrice = Convert.ToDecimal(Request.Form["UnitPrice"]);
                _product.UnitsInStock = Convert.ToInt16(Request.Form["UnitsInStock"]);
                _product.UnitsOnOrder = Convert.ToInt16(Request.Form["UnitsOnOrder"]);
                ProductDataContext.InsertProducts(_product);
                return RedirectToAction("Index");
            }
            return View(Request.Form.Count);
        }

        [HttpGet]
        public ActionResult Insert1(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> products = ProductDataContext.InsertProducts2(id);
            return View(products);
        }


        [HttpGet]
        public ActionResult Insert11(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> products = ProductDataContext.InsertProducts21(id);
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Insert1()
        {
            if (Request.Form.Count > 0)
            {
                Product _product = new Product(); ;
                _product.SupplierID = Convert.ToInt32(Request.Form["SupplierID"]);
                _product.CategoryID = Convert.ToInt32(Request.Form["CategoryID"]);
                _product.CategoryName = Request.Form["CategoryName"];
                _product.CompanyName = Request.Form["CompanyName"];
                _product.ProductName = Request.Form["ProductName"];
                _product.QuantityPerUnit = Request.Form["QuantityPerUnit"];
                _product.UnitPrice = Convert.ToDecimal(Request.Form["UnitPrice"]);
                _product.UnitsInStock = Convert.ToInt16(Request.Form["UnitsInStock"]);
                _product.UnitsOnOrder = Convert.ToInt16(Request.Form["UnitsOnOrder"]);
                ProductDataContext.InsertProducts(_product);
                return RedirectToAction("Index");
            }
            return View(Request.Form.Count);
        }
        [HttpGet]
        public ActionResult Filter1(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.InsertProducts2(id);
            return View(Products);
        }
        [HttpPost]
        public ActionResult Filter1(Models.Product login)
        {
            //ProductDataContext.InsertProducts22(login);
            if (Request.Form.Count > 0)
            {

                

                ProductDataContext.InsertProducts(login);
                //return RedirectToAction("Index");
            }
            //return View(Request.Form.Count);
            //return Json(login, JsonRequestBehavior.AllowGet);
            //return Json("filter1");
            return View("Filter2");
        }
        [HttpGet]
        public ActionResult Filter2(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.InsertProducts21(id);
            return View(Products);
        }
        [HttpPost]
        public ActionResult Filter2(Models.Product login)
        {
            //ProductDataContext.InsertProducts22(login);
            if (Request.Form.Count > 0)
            {

              
                ProductDataContext.EditProduct1(login);
                //return RedirectToAction("Index");
            }
            //return RedirectToAction("Index");
            //}
            //return View(Request.Form.Count);
            //return Json(login, JsonRequestBehavior.AllowGet);
            //return Json("filter1");
            return View("Filter2");
        }
        [HttpGet]
        public ActionResult Filter3(int id = 0)
        {
            ViewBag.CategoryID = id;
            List<Product> Products = ProductDataContext.InsertProducts21(id);
            return View(Products);
        }
        [HttpPost]
        public ActionResult Filter3(Models.Product login)
        {
            //ProductDataContext.InsertProducts22(login);
            if (Request.Form.Count > 0)
            {

                ProductDataContext.DeleteProduct1(login);
                //return RedirectToAction("Index");
            }
            //return RedirectToAction("Index");
            //}
            //return View(Request.Form.Count);
            //return Json(login, JsonRequestBehavior.AllowGet);
            //return Json("filter1");
            return View("Filter3");
        }

    }
}
