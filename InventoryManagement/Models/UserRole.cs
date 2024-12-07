using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
	public class UserRole
	{
		[Required]
		public string UserId { get; set; }
		[Required]
		public string RoleId { get; set; }
	}
}
