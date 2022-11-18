using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCPMaui.Classes
{
    public class Reactions
    {
#nullable enable

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DisplayName("ReactionsId")]
        public int? ReactionsId { get; set; }

        [DisplayName("Counter")]
        public int? Counter { get; set; }

        [DisplayName("Type")]
        public string? Type { get; set; }

        [DisplayName("PostsId")]
        public int? PostsId { get; set; }

        [DisplayName("CommentsId")]
        public int? CommentsId { get; set; }

        [DisplayName("RepliesId")]
        public int? RepliesId { get; set; }

        [DisplayName("AttachsId")]
        public int? AttachsId { get; set; }

        [DisplayName("UsersId")]
        public int? UsersId { get; set; }
    }
}
