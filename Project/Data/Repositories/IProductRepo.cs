using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;

namespace Data.Repositories
{
    public interface IProductRepo
    {
        bool AddProduct(ProductDto product);
        bool ImportProduct(ProductDto product, int count, DateTime dateCreate);
        bool SellProduct(ProductDto product, int count, DateTime dateCreate);
        List<ProductDto> GetTopProduct(int range);
        List<ProductDto> GetAll();
        bool ExportToCsvFile(List<ProductDto> products, string fileName);
        ProductDto GetProduct(int id);
    }
}
