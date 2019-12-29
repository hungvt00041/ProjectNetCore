using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Data;
using CustomerMNG.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerMNG.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddOrder(Order orderModel)
        {
            _context.Order.Add(orderModel);
            _context.SaveChanges();
        }

        public List<Order> GetAllOrder()
        {
            //return _context.Products.Include(x => x.Category).ToList();
            return _context.Order.Include(x => x.ProductOrders).ThenInclude(x=>x.Product).ToList();
        }
    }
}
