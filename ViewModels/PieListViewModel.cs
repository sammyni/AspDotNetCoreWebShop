using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Models;

namespace WebShop.ViewModels
{
    public class PieListViewModel
    {

        public IEnumerable<Pie> Pies {get; set;}
        public string CurrentCategory { get; set; }
        
    }
}