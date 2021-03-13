using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Assignment5.Infrastructure;
using System.Linq;

namespace Assignment5.Pages
{
    public class BuyModel : PageModel
    {
        private IBookstoreRepository repository;


        //constructor
        public BuyModel(IBookstoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        //properties

        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        //methods

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            // Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

            // HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
