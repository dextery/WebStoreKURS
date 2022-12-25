using DataAccess.Entities;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Identity;


namespace DataAccess.Repository
{
	public class OrdersRepository : IAllOrders
	{
		private readonly AppDBContent appDBContent;
		private readonly UserManager<ApplicationUser> userManager;

		public OrdersRepository(AppDBContent appDBContent, UserManager<ApplicationUser> userManager)
		{
			this.appDBContent = appDBContent;
			this.userManager = userManager;
		}

		public void createOrder(Order order)
		{
			foreach (var user in userManager.Users)
			{
				order.email = user.Email;
			}
			order.orderTime = DateTime.Now;
			appDBContent.Order.Add(order);
			
			appDBContent.SaveChanges();
		}
	}
}
