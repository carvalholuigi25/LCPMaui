using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCPMaui.Classes
{
    public class Attachments
    {
#nullable enable

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DisplayName("AttachsId")]
        public int? AttachsId { get; set; }

        [DisplayName("Title")]
        public string? Title { get; set; }

        [DisplayName("Type")]
        public string? Type { get; set; }

        [DisplayName("File")]
        public string? File { get; set; }

        [DisplayName("Date of File Uploaded")]
        public DateTime? DateFileUploaded { get; set; }

        [DisplayName("Date of File Modified")]
        public DateTime? DateFileModified { get; set; }

        [DisplayName("Date of File Deleted")]
        public DateTime? DateFileDeleted { get; set; }

        [DisplayName("Status")]
        public string? Status { get; set; }

        [DisplayName("Privacy")]
        public string? Privacy { get; set; }

        [DisplayName("IsFeatured")]
        public bool? IsFeatured { get; set; }

        [DisplayName("ReactionsId")]
        public int? ReactionsId { get; set; }

        [DisplayName("PostsId")]
        public int? PostsId { get; set; }

        [DisplayName("UsersId")]
        public int? UsersId { get; set; }
    }
}
