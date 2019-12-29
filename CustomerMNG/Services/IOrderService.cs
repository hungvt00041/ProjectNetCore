using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerMNG.Models;
using CustomerMNG.ViewModels;

namespace CustomerMNG.Services
{
    public interface IOrderService
    {
        public void Add(OrderViewModel order);

        public List<OrderViewModel> GetAllOrder();
    }
}
