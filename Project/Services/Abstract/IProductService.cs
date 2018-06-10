using System;
using System.Collections.Generic;
using Data.Dtos;

namespace Services.Abstract
{
    public interface IProductService
    {
        void AddProduct(ProductDto product, string tpye);
        void ImportProduct(ImportProductDto importInformation, DateTime dateCreate);

        List<ProductDto> GetTopAccessories(int top);
        List<ProductDto> GetTopProduct(int top);
        List<ProductDto> GetAllProduct(string type);
        ProductDto GetProductByID(int ID, string type);
        int GetIDProduct(string productName);
        List<ProductDto> GetTopVehicles(int top);

        List<MasterDataDto> GetAllStatusOfProduct();
        List<MasterDataDto> GetAllTypeOfVehicle();
        List<MasterDataDto> GetAllTypeOfAccessory();

        string[] GetAllProductName();
        string[] GetAllProductName(string type);

        List<ImportProductDto> LoadAllImportInformation();
        List<SellProductDto> LoadAllSellInformation();

        List<StockDto> LoadStockInformation();
        List<StockDto> LoadStockInformation(int top);
        List<StockDto> GetStockInformationWithType(string type);
        List<StockDto> GetStockInformationOfProduct(int ID);

        List<string> GetAllClassification();
        List<string> GetAllStatus();
        string GetCodeNameOfClassification(string type);
        string GetCodeNameOfStatus(string status);

        // sell and order product
        string SellProduct(SellProductDto sellInformation, DateTime dateCreate);
        string OrderProduct(OrderDetailDto order, DateTime dateCreate);
        List<OrderDetailDto> GetAllOrdersAreWaiting();
        List<OrderDetailDto> GetAllOrdersAreCensorred();
        /// <summary>
        /// Change status of order
        /// </summary>
        /// <param name="OrderId"> ID of order in db</param>
        /// <param name="status">use Constant.STATUS_CENSORRED and Constant.STATUS_WAITING</param>
        /// <returns></returns>
        string ChangeStatusOfOrder(int orderId, string status);

        #region ExportToCsv
        bool ExportToCsvFile(List<ProductDto> products, string fileName);
        bool ExportToCsvFile(List<ImportProductDto> products, string fileName);
        bool ExportToCsvFile(List<OrderDetailDto> products, string fileName);
        bool ExportToCsvFile(List<SellProductDto> products, string fileName);
        bool ExportToCsvFile(List<StockDto> products, string fileName);
        #endregion

        void EditVehicle(ProductDto vehicle);

        #region GetAndSetStoreInformation
        string GetNameStore();
        string GetTitleStore();
        string GetAddressStore();
        void SetStoreInformation(string name, string title, string address);
        #endregion

    }
}
