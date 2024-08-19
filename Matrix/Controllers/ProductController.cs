using AutoMapper;
using BLL.INTERFACES;
using DAL.ENTITIES;
using Matrix.VM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Matrix.Controllers
{
    public class ProductController : Controller
    {
        IPRODUCT productInterface;
        ICART cartInterface;
        IAccount _Account;
        IMapper mapper;

        public ProductController(IPRODUCT _productInterface, ICART _cartInterface, IAccount Account, IMapper Mapper)
        {
            productInterface = _productInterface;
            cartInterface = _cartInterface;
            _Account = Account;
            mapper = Mapper;
        }


        public IActionResult GetAll()
        {
            List<Product> products = productInterface.AllProducts();
            ViewBag.NewProducts = productInterface.GetNew();
            ViewBag.TopProducts = productInterface.GetTop();
            string? id = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ViewBag.CartCount = cartInterface.CartCount(id);
            ViewBag.UserName = _Account.GetUserName(id);
            return View(products);
        }
        public IActionResult GetLaptops()
        {
            var Products = productInterface.GetLaptops();
            return View("GetAll", Products);
        }
        public IActionResult GetPhones()
        {
            var Products = productInterface.GetPhones();
            return View("GetAll", Products);
        }
        public IActionResult GetCameras()
        {
            var Products = productInterface.GetCameras();
            return View("GetAll", Products);
        }
        public IActionResult GetHeadphones()
        {
            var Products = productInterface.GetHeadphones();
            return View("GetAll", Products);
        }

        [HttpGet]
        public IActionResult GetProduct(int Id)
        {

            var product = productInterface.GetProduct(Id);
            string? id = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ViewBag.CartCount = cartInterface.CartCount(id);
            ViewBag.UserName = _Account.GetUserName(id);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetProductByName(string Name)
        {
            var Product = productInterface.GetProductByName(Name);
            return View(Product);
        }
        public IActionResult EditButton()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteProduct(int _id)
        {
            int id = _id;
            Product prod = productInterface.GetProduct(id);
            productInterface.DeleteProduct(prod);
            return RedirectToAction("GetAll", "Product");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int _id)
        {
            int id = _id;
            var Product = productInterface.GetProduct(id);
            return View(Product);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult EditGetAll(int Id)
        {
            var Product = productInterface.GetProduct(Id);
            return View("Edit", Product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(Product product)
        {
            productInterface.EditProduct(product);
            return RedirectToAction("GetProduct", (product));
        }
        public IActionResult DeleteButton()
        {
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AddProduct()
        {
            return View(new ProductVM());
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(ProductVM product)
        {
            if (ModelState.IsValid)
            {
                var MappedProduct = mapper.Map<ProductVM, Product>(product);
                productInterface.AddProduct(MappedProduct);
                int id = productInterface.GetId(MappedProduct);
                return RedirectToAction("GetProduct", "Product", new { id });
            }
            return View(product);
        }
        [Authorize]
        [HttpGet]
        public IActionResult GetAllAddToCart(
            int ProId, string ProName, string ProImage, decimal Proprice, string Prosection, string id)
        {
            cartInterface.AddToCart(ProId, ProName, ProImage, Proprice, Prosection, id);
            return RedirectToAction("GetAll", "Product");
        }
        [Authorize]
        [HttpGet]
        public IActionResult GetProductAddToCart(
            int ProId, string ProName, string ProImage, decimal Proprice, string Prosection, string id)
        {

            cartInterface.AddToCart(ProId, ProName, ProImage, Proprice, Prosection, id);

            return RedirectToAction("GetProduct", "Product", new { id = ProId });
        }

    }
}
