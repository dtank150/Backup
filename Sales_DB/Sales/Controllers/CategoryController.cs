using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Sales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class CategoryController : Controller
    {

        private IWebHostEnvironment _hostingEnvironment;
        private ICategory _catrgoryRepository;

        public CategoryController(IWebHostEnvironment hostEnvironment,ICategory categoryRepository)
        {
            _hostingEnvironment = hostEnvironment;
            _catrgoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View(_catrgoryRepository.GetAllCategory());
        }
        public IActionResult AddCategory(string name)
        {
            Category category = new Category() { Name = name };
            return Json(_catrgoryRepository.AddCategory(category));
        }
    }
}
