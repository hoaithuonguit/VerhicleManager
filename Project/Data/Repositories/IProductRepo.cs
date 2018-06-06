using System;
using System.Collections.Generic;
using Data.Dtos;

namespace Data.Repositories
{
    public interface IProductRepo
    {
        string AddProduct(ProductDto product, string type);
        string ImportProduct(ImportProductDto importInformation, DateTime dateCreate);

        List<ProductDto> GetTopAccessories(int top);
        List<ProductDto> GetAll(string type);
        ProductDto GetProduct(int id, string type);
        List<ProductDto> GetTopVehicles(int top);
        List<ImportProductDto> GetImportInformation();
        List<SellProductDto> GetSellInformation();
        List<StockDto> GetStockInformation();

        bool ExportToCsvFile(List<ProductDto> products, string fileName);
        bool EditVehicle(ProductDto vehicle);
       
        
    }
}
