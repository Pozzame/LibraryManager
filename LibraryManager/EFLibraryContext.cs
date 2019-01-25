using Microsoft.EntityFrameworkCore;

namespace EFLibraryManager
{
    public class EFLibraryContext : DbContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=EFLibraryManager;
                                            Integrated Security=True;
                                            MultipleActiveResultSets=true");
        }
    }
}