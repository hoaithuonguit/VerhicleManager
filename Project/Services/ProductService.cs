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

        public void ExportToCsv(List<ProductDto> products, string fileName)
        {
            _repository.ExportToCsvFile(products, fileName);
        }

        public List<ProductDto> GetTopVehicles(int top)
        {
            return _repository.GetTopVehicles(top);
        }

        public void EditVehicle(ProductDto vehicle)
        {
            _repository.EditVehicle(vehicle);
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

        public string ChangeStatusOfOrder(int orderId, string status)
        {
            return _repository.ChangeStatusOfOrder(orderId, status);
        }

        public List<ProductDto> GetTopCategory(int top)
        {
            return _repository.GetTopAccessories(top);
        }

    }
}
