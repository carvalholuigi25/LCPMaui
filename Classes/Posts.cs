using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCPMaui.Classes
{
    public class Posts
    {
#nullable enable

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DisplayName("PostsId")]
        public int? PostsId { get; set; }

        [DisplayName("Title")]
        public string? Title { get; set; }

        [DisplayName("Desc")]
        public string? Desc { get; set; }

        [DisplayName("Text")]
        public string? Text { get; set; }

        [DisplayName("Category")]
        public string? Category { get; set; }

        [DisplayName("Image")]
        public string? Image { get; set; }

        [DisplayName("Cover")]
        public string? Cover { get; set; }

        [DisplayName("Date Created")]
        public DateTime? DateCreated { get; set; }

        [DisplayName("Status")]
        public string? Status { get; set; }

        [DisplayName("Privacy")]
        public string? Privacy { get; set; }

        [DisplayName("IsFeatured")]
        public bool? IsFeatured { get; set; }

        [DisplayName("ReactionsId")]
        public int? ReactionsId { get; set; }

        [DisplayName("AttachsId")]
        public int? AttachsId { get; set; }

        [DisplayName("UsersId")]
        public int? UsersId { get; set; }
    }
}
