using HangApi.Database.InitialData;
using HangApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HangApi.Database
{
    public class WordsContext : DbContext
    {
        public WordsContext(DbContextOptions<WordsContext> options) : base(options)
        {           
        
        }

        public DbSet<Words> wordss { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Words>().HasKey(x => x.Id);
            modelBuilder.Entity<Words>().Property(x => x.Theme).IsRequired();

            modelBuilder.Entity<Words>().HasData(WordsInitialData.DataSeed);


        }
    }
}
