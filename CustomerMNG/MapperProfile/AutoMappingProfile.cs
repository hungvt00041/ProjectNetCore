using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustomerMNG.Models;
using CustomerMNG.ViewModels;

namespace CustomerMNG.MapperProfile
{
    public class AutoMappingProfile :Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<Order, OrderViewModel>();
            CreateMap<OrderViewModel, Order>();

            
            CreateMap<ProductViewModel, Product>();
            CreateMap<Product, ProductViewModel>().ForMember(dest=>dest.ProductViewName, origin=>origin.MapFrom(src=>src.Name));
        }
    }
}
