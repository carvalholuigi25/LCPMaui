using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCPMaui.Classes
{
    public class Comments
    {
#nullable enable

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DisplayName("CommentsId")]
        public int? CommentsId { get; set; }

        [DisplayName("Text")]
        public string? Text { get; set; }

        [DisplayName("Date Created")]
        public DateTime? DateCreated { get; set; }

        [DisplayName("Status")]
        public string? Status { get; set; }

        [DisplayName("Privacy")]
        public string? Privacy { get; set; }

        [DisplayName("PostsId")]
        public int? PostsId { get; set; }

        [DisplayName("ReactionsId")]
        public int? ReactionsId { get; set; }

        [DisplayName("AttachsId")]
        public int? AttachsId { get; set; }

        [DisplayName("UsersId")]
        public int? UsersId { get; set; }
    }
}
