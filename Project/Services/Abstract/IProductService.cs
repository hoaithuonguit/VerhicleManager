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
        void AddProduct(ProductDto product, string tpye);

        void ImportProduct(ProductDto product, int count, DateTime dateCreate);

        void SellProduct(ProductDto product, int count, DateTime dateCreate);

        List<ProductDto> GetTopProduct(int top);

        List<ProductDto> GetAllProduct(string type);

        ProductDto GetProductByID(int ID, string type);

        void ExportToCsv(List<ProductDto> products, string fileName);

        List<ProductStatusDto> GetAllProductStatus(string key1, string key2 = "", string key3 = "");

        List<ProductTypeDto> GetAllProductType(string key1, string key2 = "", string key3 = "");

        List<MasterInfoDto> GetAllMasterInfo(string key1, string key2 = "", string key3 = "");

        List<ProductDto> GetTopVehicles(int top);

        void EditVehicle(ProductDto vehicle);
    }
}
