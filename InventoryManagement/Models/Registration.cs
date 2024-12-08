using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
	public class Registration
	{
        [DisplayName("User Id")]
        [Required]
        public string dto_UserID { get; set; }
        [DisplayName("Name")]
        [Required]
        public string dto_Name { get; set; }
        [DisplayName("Email")]
        [Required]
        public string dto_Email { get; set; }
        [DisplayName("Role")]
        [Required]
        public string dto_Role { get; set; }
        [DisplayName("User Name")]
        [Required]
        public string dto_UserName { get; set; }
        [DisplayName("Phone")]
        [Required]
        public string dto_phone { get; set; }
        [DisplayName("Password")]
        [Required]
        public string dto_Password { get; set; }
        [DisplayName("Confirm Password")]
        [Required]
        public string dto_ConfirmPassowrd { get; set; }
        [Required]
        public DateTime dto_CreatedOn { get; set; }
        [Required]
        public string dto_CreatedBy { get; set; }
        [Required]
        public DateTime dto_ModifiedOn { get; set; }
        [Required]
        public string dto_ModifiedBy { get; set; }
    }
}
