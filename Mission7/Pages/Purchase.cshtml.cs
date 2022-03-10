using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission7.Infrastructure;
using Mission7.Models;


namespace Mission7.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookRepository repo { get; set; }

<<<<<<< Updated upstream:Mission7/Pages/AddBook.cshtml.cs
        public AddBookModel(IBookRepository temp)
=======
        public PurchaseModel(IBookRepository temp, Basket  b)
>>>>>>> Stashed changes:Mission7/Pages/Purchase.cshtml.cs
        {
            repo = temp;
        }

        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            returnUrl = returnUrl ?? "/";
            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookID == bookId);

            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            basket.AddItem(b, 1);

            HttpContext.Session.SetJson("basket", basket);

            return RedirectToPage(new { ReturnUrl = returnUrl });

        }
    }
}
