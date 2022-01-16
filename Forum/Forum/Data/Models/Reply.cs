using System.ComponentModel.DataAnnotations;

namespace Forum.Data.Models
{
    public class Reply
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string ReplyText { get; set; }

        [Required]
        public int TopicId { get; set; }

        public Topic Topic { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}
