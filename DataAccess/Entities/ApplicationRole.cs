using Microsoft.AspNetCore.Identity;
namespace DataAccess.Entities
{
	public class ApplicationRole : IdentityRole
	{
		public List<ApplicationUser> Users { get; set; }
	}
}
