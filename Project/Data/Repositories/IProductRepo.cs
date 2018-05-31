using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Infrastructure;

namespace Data.Repositories
{
    public interface IProductRepo
    {
        bool AddProduct(ProductDto product, string type);
        bool ImportProduct(ProductDto product, int count, DateTime dateCreate);
        bool SellProduct(ProductDto product, int count, DateTime dateCreate);
        List<ProductDto> GetTopProduct(int top);
        List<ProductDto> GetAll();
        bool ExportToCsvFile(List<ProductDto> products, string fileName);
        ProductDto GetProduct(int id);
        bool EditVehicle(ProductDto vehicle);
        List<ProductDto> GetTopVehicles(int top);

    }
}
