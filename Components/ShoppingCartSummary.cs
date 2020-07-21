using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }
        public IViewComponentResult Invoke()
        {
            var result = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = result;
            var viewModel = new ShoppingCartViewModel { ShoppingCart = shoppingCart,
            ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };
            return View(viewModel);
        }
    }
}
