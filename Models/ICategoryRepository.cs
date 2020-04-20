using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }           

    }
}