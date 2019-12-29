using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;
using CustomerMNG.Repositories;
using CustomerMNG.ViewModels;

namespace CustomerMNG.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;
        public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }
        public void Add(OrderViewModel order)
        {
            Order orderModel = new Order { NumberOfOrder = order.NumberOfOrder, PurchaseDate = order.PurchaseDate };

            foreach(var productId in order.ProductIds)
            {
                var productOrder = new ProductOrder()
                {
                    OrderId = orderModel.Id,
                    ProductId = productId
                };
                orderModel.ProductOrders.Add(productOrder);
            }
            _repo.AddOrder(orderModel);

        }

        public List<OrderViewModel> GetAllOrder()
        {
            var orders = _repo.GetAllOrder();
            List<OrderViewModel> viewModels = new List<OrderViewModel>();
            foreach (var order in orders)
            {
                viewModels.Add(new OrderViewModel
                {
                    Id = order.Id,
                    NumberOfOrder = order.NumberOfOrder,
                    PurchaseDate = order.PurchaseDate,
                    ProductOrders = order.ProductOrders,
                }); ;
            }
            return viewModels;
        }
    }
}
