using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bookstore.Models
{
    public class BookstoreDatabaseContext : DbContext
    {
        public BookstoreDatabaseContext()
        {
        }

        public BookstoreDatabaseContext(DbContextOptions<BookstoreDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
    }
}

