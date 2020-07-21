using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieRepository;
        private readonly ICategoryRepository categoryRepository;

      
        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            this.pieRepository = pieRepository;
            this.categoryRepository = categoryRepository;
        }
        public IActionResult List(string category)
        {
            IEnumerable<Pie> result;
            string currentCategory;
            if (!string.IsNullOrEmpty(category))
            {
                result = pieRepository.AllPies.Where(p => p.Category.Name.Equals(category));
                currentCategory = category;
            }
            else
            {
                result = pieRepository.AllPies;
                currentCategory = "All Pies";
            }
            return View(new PiesListViewModell { 
                Pies = result,
                CurrentCategory= currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var result = pieRepository.GetPieById(id);
            if (result == null)
                return NotFound();
            return View(result);
        }
    }
}