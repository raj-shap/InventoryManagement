using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
	public class Registration
	{
		//[Required]
		//public string UserID { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Role { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		public string phone { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		public DateTime CreatedOn { get; set; }
		[Required]
		public string CreatedBy { get; set; }
		[Required]
		public DateTime ModifiedOn { get; set; }
		[Required]
		public string ModifiedBy { get; set; }
	}
}
