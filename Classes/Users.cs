using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCPMaui.Classes
{
    public class Users
    {
#nullable enable

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DisplayName("UsersId")]
        public int? UsersId { get; set; }

        [DisplayName("Username")]
        public string? Username { get; set; }

        [DisplayName("Email")]
        public string? Email { get; set; }

        [DisplayName("Password")]
        public string? Password { get; set; }

        [DisplayName("Pin")]
        public int? Pin { get; set; }

        [DisplayName("Role")]
        public string? Role { get; set; }

        [DisplayName("About")]
        public string? About { get; set; }

        [DisplayName("Image")]
        public string? Image { get; set; }

        [DisplayName("Cover")]
        public string? Cover { get; set; }

        [DisplayName("Status")]
        public string? Status { get; set; }

        [DisplayName("Privacy")]
        public string? Privacy { get; set; }

        [DisplayName("Date Created")]
        public DateTime? DateCreated { get; set; }
    }
}
