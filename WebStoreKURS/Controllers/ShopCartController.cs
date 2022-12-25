using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data.Interfaces;
using WebStoreKURS.Data.Models;
using WebStoreKURS.Data.Repository;
using WebStoreKURS.ViewModels;

namespace WebStoreKURS.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllParts _partRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllParts partRep, ShopCart shopCart)
        {
            _partRep = partRep;
            _shopCart = shopCart;
        }
        public ViewResult ShopCartPage()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }
        public RedirectToActionResult addToCart(int id)
        {
            var item = _partRep.AllParts.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("ShopCartPage");
        }
        public RedirectToActionResult removeFromCart(int id)
        {
            var items = _shopCart.GetShopItems();
            _shopCart.listShopItems = items;
            var item = _shopCart.listShopItems.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.RemoveFromCart(item);
            }
            return RedirectToAction("ShopCartPage");
        }
    }
}
