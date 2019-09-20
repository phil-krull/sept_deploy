using Microsoft.EntityFrameworkCore;
using BooksAndAuthors.Models;
 
namespace BooksAndAuthors.Models
{
    public class Context : DbContext
    {
        public DbSet<Author> Authors {get; set;}
        public DbSet<Book> Books {get; set;}
        // base() calls the parent class' constructor passing the "options" parameter along
        public Context(DbContextOptions options) : base(options) { }
    }
}
