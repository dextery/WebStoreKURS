using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
	public interface IPartsCategory
    {
        IEnumerable<Categories> AllCategories { get; }
    }
}
