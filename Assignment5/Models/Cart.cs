using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem (Book book, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        public void Clear() => Lines.Clear();


        // TODO: correct this computation of total sum
        public decimal CalcTotalSum() => Lines.Sum(e => 25 * e.Quantity);


        public class CartLine
        {
            public int CartLineID { get; set; }

            public Book Book { get; set; }

            public int Quantity { get; set; }
        }
    }
}
