using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sales.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        private IProduct _productRepository;
        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _categoryRepository;

        public HomeController(/*ILogger<HomeController> logger*/ IProduct productRepository,
            IWebHostEnvironment hostEnvironment, 
            ICategory categoryRepository)
        {
            _productRepository = productRepository;
            _hostingEnvironment = hostEnvironment;
            _categoryRepository = categoryRepository;
          //  _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["PageTitle"] = "Product List";
            var result = from p in _productRepository.GetAllProduct()
                         join c in _categoryRepository.GetAllCategory()
                         on p.CatId equals c.Id
                         select new
                         {
                             p.Id,
                             p.Name,
                             p.Profile,
                             p.Qty,
                             p.Rate,
                             p.ISActive,
                             p.CatId,
                             Category = c.Name
                         };
            List<ProductsViewModel> products = new List<ProductsViewModel>();
            foreach(var each in result)
            {
                products.Add(new ProductsViewModel()
                {
                    Category = each.Category,
                    CatId = each.CatId,
                    Name = each.Name,
                    Id = each.Id,
                    Profile = each.Profile,
                    ISActive = each.ISActive,
                    Rate = each.Rate,
                    Qty = each.Qty
                });
            }
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            Product p = _productRepository.GetProductById(id);
            ProductsViewModel productsViewModel = new ProductsViewModel()
            {
                Name = p.Name,
                Qty = p.Qty,
                Rate = p.Rate,
                CatId = p.CatId,
                ISActive = p.ISActive,
                Profile = p.Profile,
                Id = p.Id
            };
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View("AddProduct", productsViewModel);
        }
        public IActionResult Delete(int id)
        {
            var product = _productRepository.GetProductById(id);
            if(product == null)
            {
                return NotFound();
            }
            _productRepository.Delete(id);
            return RedirectToAction("Index");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult CheckUpdateUnique(String name, int catId, int prodId)
        {
            bool value = _productRepository.CheckUpdateUnique(name, catId, prodId);
            return Json(value);
        }
        public IActionResult CheckInsertUnique(String name, int catId)
        {
            bool value = _productRepository.CheckInsertUnique(name, catId);
            return Json(value);
        }
        public IActionResult AddProduct()
        {
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View(new ProductsViewModel());
        }
        public IActionResult AddProduct1()
        {
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View(new ProductsViewModel());
        }
        public IActionResult Save(ProductsViewModel p)
        {
            if(ModelState.IsValid)
            {
                String uniqueFileName = string.Empty;
                if (p.Image != null)
                {
                    String uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + p.Image.FileName;
                    String uploadFilePAth = Path.Combine(uploadFolder, uniqueFileName);
                    p.Image.CopyTo(new FileStream(uploadFilePAth, FileMode.Create));
                    p.Profile = uniqueFileName;
                }
                if (p.Id > 0)
                {
                    if (!_productRepository.UpdateProduct(p))
                    {
                        ViewBag.Category = _categoryRepository.GetAllCategory();
                        return View("AddProduct", p);
                    }
                }
                else
                {
                    if (!_productRepository.AddProduct(p))
                    {
                        ViewBag.Category = _categoryRepository.GetAllCategory();
                        return View("AddProduct", p);
                    }
                }
                return RedirectToAction("Index");
            }
            ViewBag.Category = _categoryRepository.GetAllCategory();
            return View("AddProduct1", p);
            
        }
    }
}
