using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Categories
    {
        public int id { set; get; }

        public string Categoryname { set; get; }

        public string catedesc { set; get; }

        public List<Parts> parts { set; get; }
    }
}
