using DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebStoreApi.Contract;

namespace WebStoreApi.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class RolesController : ControllerBase
	{
		private RoleManager<IdentityRole> _roleManager;
		private UserManager<ApplicationUser> _userManager;


		public RolesController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
		{
			_roleManager = roleManager;
			_userManager = userManager;
		}

		[HttpGet]
		public ActionResult<RoleContract[]> GetAll()
		{
			return _roleManager.Roles.Select(x => new RoleContract { Id = x.Id, Name = x.Name }).ToArray();
		}

		[HttpPost]
		public async Task<IActionResult> Update(EditRoleContract contract)
		{
			var role = _roleManager.Roles.Single(x => x.Id == contract.Id);
			role.Name = contract.RoleName;
			await _roleManager.UpdateAsync(role).ConfigureAwait(false);

			var users = _userManager.Users.Where(x => contract.UserIds.Contains(x.Id));
			foreach(var user in users)
			{
				await _userManager.AddToRoleAsync(user, role.Name).ConfigureAwait(false);
			}

			return Ok();
		}

		[HttpPost]
		public IActionResult Delete()
		{
			return StatusCode((int)HttpStatusCode.Conflict);
		}
	}
}
