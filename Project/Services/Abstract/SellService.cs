using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Repositories;

namespace Services.Abstract
{
    public class SellService : ISellService
    {
        private ISellRepo _sellRepo;

        public SellService()
        {
            _sellRepo = new SellRepo();
        }

        public void SellProduct(ProductDto product, int count, DateTime dateCreate)
        {
            _sellRepo.SellProduct(product, count, dateCreate);
        }

        public string OrderProduct(OrderDetailDto order)
        {
            return _sellRepo.OrderProduct(order, TODO);
        }

        public List<OrderDetailDto> GetAllOrdersAreWaiting()
        {
            return _sellRepo.GetAllOrdersAreWaiting();
        }
    }
}
