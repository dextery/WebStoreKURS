using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreKURS.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Parts part { get; set; }
        public uint price { get; set; }
        public string ShopCartId { get; set; }

    }
}
