namespace Forum.Data
{
    using Forum.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Message> Messages { get; set; }

        public new DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<Message>()
                .HasOne(s => s.Sender)
                .WithMany(m => m.Messages);

            builder
                .Entity<Message>()
                .HasKey(pk => new { pk.ReceiverId, pk.SenderId });

            builder
                .Entity<Like>()
                .HasKey(pk => new { pk.UserId, pk.TopicId });

            builder
                .Entity<Like>()
                .HasOne(t => t.Topic)
                .WithMany(l => l.Likes);
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
