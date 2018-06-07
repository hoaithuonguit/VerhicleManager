using System;
using System.Collections.Generic;
using Data.Dtos;

namespace Services.Abstract
{
    public interface IProductService
    {
        void AddProduct(ProductDto product, string tpye);

        void ImportProduct(ImportProductDto importInformation, DateTime dateCreate);

        List<ProductDto> GetTopProduct(int top);

        List<ProductDto> GetAllProduct(string type);

        ProductDto GetProductByID(int ID, string type);

        void ExportToCsv(List<ProductDto> products, string fileName);

        List<ProductDto> GetTopVehicles(int top);

        void EditVehicle(ProductDto vehicle);

        List<MasterDataDto> GetAllStatusOfProduct();

        List<MasterDataDto> GetAllTypeOfVehicle();

        List<MasterDataDto> GetAllTypeOfAccessory();

        int GetIDProduct(string productName);

        List<ImportProductDto> LoadAllImportInformation();
        List<SellProductDto> LoadAllSellInformation();
        List<StockDto> LoadStockInformation();

        // sell and order product
        string SellProduct(SellProductDto sellInformation, DateTime dateCreate);
        string OrderProduct(OrderDetailDto order, DateTime dateCreate);
        List<OrderDetailDto> GetAllOrdersAreWaiting();
        /// <summary>
        /// Change status of order
        /// </summary>
        /// <param name="OrderId"> ID of order in db</param>
        /// <param name="status">use Constant.STATUS_CENSORRED and Constant.STATUS_WAITING</param>
        /// <returns></returns>
        string ChangeStatusOfOrder(int orderId, string status);

    }
}
