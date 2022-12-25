using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreKURS.Data.Models
{
    public class Categories
    {
        public int id { set; get; }

        public string categoryname { set; get; }

        public string catedesc { set; get; }

        public List<Parts> parts { set; get; }
    }
}
