using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Forum.Data.Models
{
    public class Topic
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
        public IEnumerable<Reply> Replies { get; set; } = new List<Reply>();
        public IEnumerable<Like> Likes { get; set; } = new List<Like>();
    }
}
