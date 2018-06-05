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
        void SellProduct(ProductDto product, int count, DateTime dateCreate);
        string OrderProduct(OrderDetailDto order);

        List<OrderDetailDto> GetAllOrdersAreWaiting();
    }
}
