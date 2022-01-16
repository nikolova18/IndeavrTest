using System.ComponentModel.DataAnnotations;

namespace Forum.Data.Models
{
    public class Like
    {
        [Required]
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
