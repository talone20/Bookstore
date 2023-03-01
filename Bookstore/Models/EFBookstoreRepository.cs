using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreDatabaseContext context { get; set; }
        public EFBookstoreRepository (BookstoreDatabaseContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
