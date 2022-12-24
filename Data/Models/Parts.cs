using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreKURS.Data.Models
{
    public class Parts
    {
        [BindNever]
        public int id { set; get; } //ID товара
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string img { set; get; }
        public uint price { set; get; }
        public bool isFavourite { set; get; }
        public bool isavailable { set; get; }
        public int categoryID { set; get; }
        public virtual Categories Category { set; get; }
    }
}
