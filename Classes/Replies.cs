using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCPMaui.Classes
{
    public class Replies
    {
#nullable enable

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DisplayName("RepliesId")]
        public int? RepliesId { get; set; }

        [DisplayName("Text")]
        public string? Text { get; set; }

        [DisplayName("Date Created")]
        public DateTime? DateCreated { get; set; }

        [DisplayName("Status")]
        public string? Status { get; set; }

        [DisplayName("Privacy")]
        public string? Privacy { get; set; }

        [DisplayName("CommentsId")]
        public int? CommentsId { get; set; }

        [DisplayName("PostsId")]
        public int? PostsId { get; set; }

        [DisplayName("AttachsId")]
        public int? AttachsId { get; set; }

        [DisplayName("ReactionsId")]
        public int? ReactionsId { get; set; }

        [DisplayName("UsersId")]
        public int? UsersId { get; set; }
    }
}
