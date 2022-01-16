using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Forum.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string  Password { get; set; }

        public IEnumerable<Topic> Topics { get; set; } = new List<Topic>();
        public IEnumerable<Message> Messages { get; set; } = new List<Message>();
    }
}
