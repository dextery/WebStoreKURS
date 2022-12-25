using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreKURS.Data.Interfaces;
using WebStoreKURS.Data.Models;

namespace WebStoreKURS.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;
        private readonly UserManager<ApplicationUser> userManager;

        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart, UserManager<ApplicationUser> userManager)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
            this.userManager = userManager;
        }

        public void createOrder(Order order)
        {
            foreach(var user in userManager.Users)
            {
                order.email = user.Email;
            }
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);

            var items = shopCart.listShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    partAIDI = el.part.id,
                    orderAIDI = order.id,
                    price = el.part.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
