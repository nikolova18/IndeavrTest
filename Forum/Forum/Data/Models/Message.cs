using System.ComponentModel.DataAnnotations;

namespace Forum.Data.Models
{
    public class Message
    {
        [Required]
        public string Text { get; set; }

        [Required]
        public string SenderId { get; set; }

        public User Sender { get; set; }

        [Required]
        public string ReceiverId { get; set; }

        public User Receiver { get; set; }
    }
}
