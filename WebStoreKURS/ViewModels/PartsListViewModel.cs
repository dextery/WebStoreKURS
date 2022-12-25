using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data.Models;

namespace WebStoreKURS.ViewModels
{
    public class PartsListViewModel
    {
        public IEnumerable<Parts> AllParts { get; set; }
        public string currCategory { get; set; }

    }
}
