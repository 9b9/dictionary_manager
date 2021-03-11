using Microsoft.EntityFrameworkCore;
using service.Data.Models;

namespace service.Data
{
    public class DictionaryContext : DbContext
    {
        public DictionaryContext(DbContextOptions<DictionaryContext> options) : base(options)
        { }

        public DbSet<Word> Words { get; set; }

        public DbSet<WordTranslated> WordTranslateds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite("Data Source=dictionary.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WordTranslated>()
                .HasOne(p => p.Word)
                .WithMany(b => b.WordTranslateds)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}