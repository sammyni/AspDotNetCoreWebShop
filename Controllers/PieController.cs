using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Models;
using WebShop.ViewModels;

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
        
    }
}