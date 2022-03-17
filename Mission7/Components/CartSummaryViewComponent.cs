//everthing works perfectly except for the basket. I could noty get it to work. SO if you delete this pages everything works perfectly:(
using Microsoft.AspNetCore.Mvc;
using Mission7.Models;
namespace Mission7.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private BasketLineItem basket;
        public CartSummaryViewComponent(BasketLineItem basket)
        {
            basket = basketService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}