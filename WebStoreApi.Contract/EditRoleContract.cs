using System.ComponentModel.DataAnnotations;

namespace WebStoreApi.Contract
{
	public class EditRoleContract
	{
		public string Id { get; set; }

		[Required(ErrorMessage = "Role Name is required")]
		public string RoleName { get; set; }

		public List<string> UserIds { get; set; }
	}
}