using Microsoft.EntityFrameworkCore;

namespace Crate
{
    public class MessageDbContext : DbContext
    {
        public DbSet<ChatMessage> ChatMessages { get; set; } = default!;

        public MessageDbContext() { }

        public MessageDbContext(DbContextOptions<MessageDbContext> options) : base(options) { }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MessageDbContext).Assembly);
        }
    }
}
