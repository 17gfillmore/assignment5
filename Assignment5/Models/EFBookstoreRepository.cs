using System;
using System.Linq;

namespace Assignment5.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreDbContext _context;

        // constructor
        public EFBookstoreRepository(BookstoreDbContext context)
        {
            _context = context;
        }

                                                    //dbSet of Books in BookstoreDbContext
        public IQueryable<Book> Books => _context.Books;
    }
}
