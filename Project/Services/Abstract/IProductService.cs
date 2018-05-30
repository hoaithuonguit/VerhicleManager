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

        void ImportProduct(ProductDto product, int count, DateTime dateCreate);

        void SellProduct(ProductDto product, int count, DateTime dateCreate);

        List<ProductDto> GetTopProduct(int range);

        List<ProductDto> GetAllProduct();

        ProductDto GetProductByID(int ID);

        void ExportToCsv(List<ProductDto> products, string fileName);

        List<ProductStatusDto> GetAllProductStatus(string key1, string key2 = "", string key3 = "");

        List<ProductTypeDto> GetAllProductType(string key1, string key2 = "", string key3 = "");
    }
}
