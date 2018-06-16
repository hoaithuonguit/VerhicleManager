using System;
using System.Collections.Generic;
using Data.Dtos;

namespace Data.Repositories
{
    public interface IProductRepo
    {
        string AddProduct(ProductDto product, string type);
        string AddType(string typeOfProduct, string newTypeName);
        string ImportProduct(ImportProductDto importInformation, DateTime dateCreate);

        List<ProductDto> GetAll(string type);
        ProductDto GetProduct(int id, string type);
        string[] GetAllProductName();
        // get all product name of "type"
        string[] GetAllProductName(string type);

        string[] GetAllProductNameLike(string type, string key);
        List<string> GetListProductNameLike(string type, string key);

        List<ProductDto> GetTopAccessories(int top);
        List<ProductDto> GetTopVehicles(int top);
        List<ImportProductDto> GetImportInformation();
        List<SellProductDto> GetSellInformation();
        List<StockDto> GetStockInformation();
        List<StockDto> GetStockInformation(int top);
        List<StockDto> GetStockInformationWithType(string type);
        List<StockDto> GetStockInformationOfProduct(int ID);
        bool EditVehicle(ProductDto vehicle);
        string SellProduct(SellProductDto sellInformation, DateTime dateCreate);
        string OrderProduct(OrderDetailDto order, DateTime dateCreate);
        List<OrderDetailDto> GetAllOrdersAreWaiting();
        List<OrderDetailDto> GetAllOrdersAreCensorred();
        string ChangeStatusOfOrder(int orderId, string status);

        bool ExportToCsvFile(List<ProductDto> products, string fileName);
        bool ExportToCsvFile(List<ImportProductDto> products, string fileName);
        bool ExportToCsvFile(List<OrderDetailDto> products, string fileName);
        bool ExportToCsvFile(List<SellProductDto> products, string fileName);
        bool ExportToCsvFile(List<StockDto> products, string fileName);
    }
}
