using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebStoreKURS.Data.Models;
using WebStoreKURS.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace WebStoreKURS.Api
{
	[ApiController]
	[Route("api/roles")]
	[Authorize(Roles = "Admin")]
	public class RolesController : Controller
	{
		private readonly RoleManager<IdentityRole> _roleManager;

		public RolesController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
		{
			_roleManager = roleManager;
		}

		[HttpGet]
		public IdentityRole[] Get()
		{
			return _roleManager.Roles.ToArray();
		}

		[HttpPost]
		public async Task<IActionResult> Update(EditRoleViewModel model)
		{
			var role = await _roleManager.FindByIdAsync(model.Id);

			if (role == null)
			{
				return BadRequest($"Роль с Id = {model.Id} не найдена.");
			}

			role.Name = model.RoleName;
			var result = await _roleManager.UpdateAsync(role);

			foreach (var error in result.Errors)
			{
				ModelState.AddModelError(error.Code, error.Description);
			}

			if (!result.Succeeded)
			{
				return BadRequest($"Что-то пошло не так");
			}

			return Ok();
		}

	}
}
