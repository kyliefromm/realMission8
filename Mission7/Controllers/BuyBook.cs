using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission7.Models;
using Mission7.Models.ViewModels;

namespace Mission7.Controllers
{
    public class BuyBook : Controller
    {

        private IBuyBookRepository repo { get; set; }
        private Basket basket { get; set; }
        public BuyBook(IBuyBookRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Book());
        }

        [HttpPost]
        public IActionResult Checkout(Book book)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your basket is empty!");
            }
            if (ModelState.IsValid)
            {
                book.Lines = basket.Items.ToArray();
                repo.SaveBook(book);
                basket.ClearBasket();


                return RedirectToPage("/donationConfirmation");
            }
            else
            {
                return View();
            }
        }
    }
}