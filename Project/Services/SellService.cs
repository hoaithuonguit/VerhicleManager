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

        public void SellProduct(SellProductDto sellInformation, DateTime dateCreate)
        {
            _sellRepo.SellProduct(sellInformation, dateCreate);
        }

        public string OrderProduct(OrderDetailDto order, DateTime dateCreate)
        {
            return _sellRepo.OrderProduct(order, dateCreate);
        }

        public List<OrderDetailDto> GetAllOrdersAreWaiting()
        {
            return _sellRepo.GetAllOrdersAreWaiting();
        }
    }
}
