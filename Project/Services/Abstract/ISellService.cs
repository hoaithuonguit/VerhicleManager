using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;

namespace Services.Abstract
{
    public interface ISellService
    {
        void SellProduct(SellProductDto sellInformation, DateTime dateCreate);
        string OrderProduct(OrderDetailDto order, DateTime dateCreate);

        List<OrderDetailDto> GetAllOrdersAreWaiting();
    }
}
