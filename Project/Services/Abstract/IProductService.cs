using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;

namespace Services.Abstract
{
    public interface IProductService
    {
        void AddProduct(ProductDto product);

        void ImportProduct(ProductDto product, int count);

        void SellProduct(ProductDto product, int count);

        List<ProductDto> GetTopProduct(int range);

        List<ProductDto> GetAllProduct();

        ProductDto GetProductByID(int ID);

        void ExportToCsv(List<ProductDto> products, string fileName);
    }
}
