using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly ShoppingCart shoppingCart;

        public OrderRepository(AppDbContext appDbContext,ShoppingCart shoppingCart)
        {
            this.appDbContext = appDbContext;
            this.shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderDetails = new List<OrderDetail>();

            foreach (var item in shoppingCart.ShoppingCartItems)
            {

                var orderDetail = new OrderDetail
                {
                    Amount = item.Amount,
                    PieId = item.Pie.Id,
                    Price = item.Pie.Price
                };

                order.OrderDetails.Add(orderDetail);

            }
            appDbContext.Orders.Add(order);

            appDbContext.SaveChanges();
        }
    }
}
