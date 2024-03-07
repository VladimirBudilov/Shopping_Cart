using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;
using ShoppingCart.Models.ViewModels;

namespace ShoppingCart.Data.Components
{
    public class SmallCartViewComponent : ViewComponent   
    {
        public IViewComponentResult Invoke()
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
            SmallCartViewModel smallCartVM;

            if (cart == null)
            {
                smallCartVM = null;
            }
            else
            {
                smallCartVM = new()
                {
                    NumberOfItems = cart.Sum(c => c.Quantity),
                    TotalAmount = cart.Sum(c => c.Quantity * c.Price)
                };
            }

            return View(smallCartVM);

        }
    }
}
