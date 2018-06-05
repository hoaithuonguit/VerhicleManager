using System;
using System.Collections.Generic;
using Data.Dtos;
using Data.Infrastructure;
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

        public void ImportProduct(ProductDto product, int count, DateTime dateCreate)
        {
            _repository.ImportProduct(product, count, dateCreate);
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
    }
}
