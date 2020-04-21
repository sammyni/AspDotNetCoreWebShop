using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Models;
using WebShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    public class PieController: Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
            
        }

        public ViewResult List()
        {
            ViewBag.CurrentCategory = "Cheese cakes";

            PieListViewModel pieLiistViewModel = new PieListViewModel();

            pieLiistViewModel.Pies = _pieRepository.AllPies;
            pieLiistViewModel.CurrentCategory = "Cheese cakes";

            return View(pieLiistViewModel);
        }


        public IActionResult Details(int id)
        {
            Pie pie = _pieRepository.GetPieById(id);

            if (pie == null)
                return NotFound();
            return View(pie);

        }
        
    }
}