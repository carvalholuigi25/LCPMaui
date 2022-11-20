using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LCPMaui.Classes
{
    public class Feedback
    {
        #nullable enable

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DisplayName("FeedbackId")]
        public int? FeedbackId { get; set; }

        [DisplayName("Title")]
        [Required]
        public string? Title { get; set; }

        [DisplayName("Description")]
        [Required]
        public string? Description { get; set; }

        [DisplayName("AttachmentFile")]
        public string? AttachmentFile { get; set; }

        [DisplayName("Upvotes")]
        public int? Upvotes { get; set; }

        [DisplayName("Downvotes")]
        public int? Downvotes { get; set; }

        [DisplayName("Status")]
        public StatusType? Status { get; set; }

        [DisplayName("DateStart")]
        public DateTime? DateStart { get; set; }

        [DisplayName("DateEnd")]
        public DateTime? DateEnd { get; set; }

        [DisplayName("UsersId")]
        public int? UsersId { get; set; }
    }

    public enum StatusType
    {
        resolved = 0,
        pending = 1,
        starting = 2,
        paused = 3,
        alreadyfixed = 4,
        alreadyasked = 5,
        closed = 6,
        moved = 7,
        locked = 8,
        unlocked = 9,
        open = 10,
        hotfix = 11,
        fixedfully = 12,
        added = 13,
        modified = 14,
        deleted = 15,
        updated = 16,
        workinprogress = 17,
        other = 18
    }
}
