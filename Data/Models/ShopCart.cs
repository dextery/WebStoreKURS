using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreKURS.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; //Создание новой сессии
            var context = services.GetService<AppDBContent>(); //Получение таблиц
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); //обращение к сессии, взять элемент из сессии у которого ключ CartId. Если не существует, то создать новый Id.
            // по сути - создание новой переменной shop cart id, установка у неё значения из сессии, если этого значения нет, то создаётся новая строка-идентификатор и устанавливается для новго shop cart id.
            session.SetString("CartId", shopCartId); // установление новой сессии

            return new ShopCart(context) { ShopCartId = shopCartId };

        }

        public void AddToCart(Parts part)
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem 
            {
                ShopCartId = ShopCartId,
                part = part,
                price = part.price
            });

            appDBContent.SaveChanges();
        }
        public void RemoveFromCart(ShopCartItem item)
        {
            appDBContent.ShopCartItem.Remove(item);
            appDBContent.SaveChanges();
        }
        public List<ShopCartItem> GetShopItems()
        {
            return appDBContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.part).ToList();
        }
    }
}
