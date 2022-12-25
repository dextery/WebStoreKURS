using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data.Interfaces;
using WebStoreKURS.Data.Models;

namespace WebStoreKURS.Data.Repository
{
    public class CategoryRepository : IPartsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Categories> AllCategories => appDBContent.Category;
    }
}
