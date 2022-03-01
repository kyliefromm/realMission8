using System;
using Microsoft.AspNetCore.Mvc;

namespace Mission7.Controllers
{
    public class BuyBook : Controller
    {

    private IDonationRepository repo { get; set; }
    private Basket basket { get; set; }
    public DonationController(IDonationRepository temp, Basket b)
    {
        repo = temp;
        basket = b;
    }
    // GET: /<controller>/
    [HttpGet]
    public IActionResult Checkout()
    {
        return View(new Donation());
    }

    [HttpPost]
    public IActionResult Checkout(Donation donation)
    {
        if (basket.Items.Count() == 0)
        {
            ModelState.AddModelError("", "Sorry, your basket is empty!");
        }
        if (ModelState.IsValid)
        {
            donation.Lines = basket.Items.ToArray();
            repo.SaveDonation(donation);
            basket.ClearBasket();


            return RedirectToPage("/donationConfirmation");
        }
        else
        {
            return View();
        }
    }
}