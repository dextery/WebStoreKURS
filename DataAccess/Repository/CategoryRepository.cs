using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repository
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
