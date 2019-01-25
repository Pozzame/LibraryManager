using Microsoft.EntityFrameworkCore;
namespace EFLibraryManager
{
    public class EFLibraryContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"");
        }
    }
}