using System;
using Microsoft.EntityFrameworkCore;

namespace Mission7.Models
{
    public class BookContext : DbContext
    {
        public BookContext()
        {
        }

        public BookContext (DbContextOptions<BookContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
        public DbSet<Purchase> Purchases { get; set; }
>>>>>>> Stashed changes
=======
        public DbSet<Purchase> Purchases { get; set; }
>>>>>>> Stashed changes
    }
}
