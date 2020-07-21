using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public MockCategoryRepository()
        {

        }
        public IEnumerable<Category> AllCategories =>
                new List<Category>{
                    new Category{Id=1,Name="Friut Pies",Description="All Fruity Pies"},
                    new Category{Id=2,Name="Cheese cakes",Description="Cheesy All the way"},
                    new Category{Id=3,Name="Seasonal Pies",Description="Get in the mood for seasonal pies"},

                 };
        

    }
}
