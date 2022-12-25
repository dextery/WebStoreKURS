using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data.Models;

namespace WebStoreKURS.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Parts> favParts { get; set; }
    }
}
