using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data.Models;

namespace WebStoreKURS.Data.Interfaces
{
    public interface IPartsCategory
    {
        IEnumerable<Categories> AllCategories { get; }
    }
}
