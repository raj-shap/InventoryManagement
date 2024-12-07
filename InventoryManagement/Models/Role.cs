using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
	public class Role
	{
		[Required]
		public string Id { get; set; }
		[Required]
		public string Name { get; set; }
	}
}
