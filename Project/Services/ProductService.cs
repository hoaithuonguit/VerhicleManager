using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using Data.Dtos;
using Data.Infrastructure;
using Data.Model;
using Data.Repositories;
using Services.Abstract;

namespace Services
{
    public class ProductService : IProductService
    {
        private IProductRepo _repository;

        public ProductService()
        {
            this._repository = new ProductRepo();
        }
        public void AddProduct(ProductDto product, string type)
        {
            _repository.AddProduct(product, type);
        }

        public void ImportProduct(ImportProductDto importInformation, DateTime dateCreate)
        {
            _repository.ImportProduct(importInformation, dateCreate);
        }

        public List<ProductDto> GetTopAccessories(int top)
        {
            return _repository.GetTopAccessories(top);
        }
        public List<ProductDto> GetTopVehicles(int top)
        {
            return _repository.GetTopVehicles(top);
        }
        public List<ProductDto> GetTopProduct(int top)
        {
            return _repository.GetTopAccessories(top);
        }
        public List<ProductDto> GetAllProduct(string type)
        {
            return _repository.GetAll(type);
        }
        public ProductDto GetProductByID(int ID, string type)
        {
            return _repository.GetProduct(ID, type);
        }
        
        
        public string GetNameStore()
        {
            return Helper.GetNameStore();
        }
        public void SetNameStore(string name)
        {
            Helper.SetNameStore(name);
        }
        public string GetTitleStore()
        {
            return Helper.GetTitleStore();
        }
        public void SetTitleStore(string title)
        {
            Helper.SetTitleStore(title);
        }
        public string GetAddressStore()
        {
            return Helper.GetAddrStore();
        }
        public void SetAddressStore(string address)
        {
            Helper.SetAddrStore(address);
        }

        public List<MasterDataDto> GetAllStatusOfProduct()
        {
            return Helper.GetMasterData("Status");
        }
        public List<MasterDataDto> GetAllTypeOfVehicle()
        {
            return Helper.GetMasterData("TypeV");
        }
        public List<MasterDataDto> GetAllTypeOfAccessory()
        {
            return Helper.GetMasterData("Type");
        }

        public string[] GetAllProductName()
        {
            return _repository.GetAllProductName();
        }
        public string[] GetAllProductName(string type)
        {
            return _repository.GetAllProductName(type);
        }
        public int GetIDProduct(string productName)
        {
            return Helper.GetIDFromName(productName);
        }

        public List<ImportProductDto> LoadAllImportInformation()
        {
            return _repository.GetImportInformation();
        }
        public List<SellProductDto> LoadAllSellInformation()
        {
            return _repository.GetSellInformation();
        }
        public List<StockDto> LoadStockInformation()
        {
            return _repository.GetStockInformation();
        }

        public List<StockDto> GetStockInformationWithType(string type)
        {
            return _repository.GetStockInformationWithType(type);
        }
        public List<StockDto> GetStockInformationOfProduct(int ID)
        {
            return _repository.GetStockInformationOfProduct(ID);
        }
        public List<string> GetAllClassification()
        {
            return Helper.GetAllValueInMasterData("Type");
        }
        public List<string> GetAllStatus()
        {
            return Helper.GetAllValueInMasterData("Status");
        }
        public string GetCodeNameOfClassification(string type)
        {
            return Helper.GetNameFromValueInMaster(type);
        }
        public string GetCodeNameOfStatus(string status)
        {
            return Helper.GetNameFromValueInMaster(status);
        }

        public string SellProduct(SellProductDto sellInformation, DateTime dateCreate)
        {
            return _repository.SellProduct(sellInformation, dateCreate);
        }

        public string OrderProduct(OrderDetailDto order, DateTime dateCreate)
        {
            return _repository.OrderProduct(order, dateCreate);
        }

        public List<OrderDetailDto> GetAllOrdersAreWaiting()
        {
            return _repository.GetAllOrdersAreWaiting();
        }

        public List<OrderDetailDto> GetAllOrdersAreCensorred()
        {
            return _repository.GetAllOrdersAreCensorred();
        }

        public string ChangeStatusOfOrder(int orderId, string status)
        {
            return _repository.ChangeStatusOfOrder(orderId, status);
        }

        public bool ExportToCsvFile(List<ProductDto> products, string fileName)
        {
            return _repository.ExportToCsvFile(products, fileName);
        }

        public bool ExportToCsvFile(List<ImportProductDto> products, string fileName)
        {
            return _repository.ExportToCsvFile(products, fileName);
        }
        public bool ExportToCsvFile(List<OrderDetailDto> products, string fileName)
        {
            return _repository.ExportToCsvFile(products, fileName);
        }
        public bool ExportToCsvFile(List<SellProductDto> products, string fileName)
        {
            return _repository.ExportToCsvFile(products, fileName);
        }
        public bool ExportToCsvFile(List<StockDto> products, string fileName)
        {
            return _repository.ExportToCsvFile(products, fileName);
        }
        
        public void EditVehicle(ProductDto vehicle)
        {
            _repository.EditVehicle(vehicle);
        }
    }
}
