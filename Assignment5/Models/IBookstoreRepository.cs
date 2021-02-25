using System;
using System.Linq;

namespace Assignment5.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }

    }
}
