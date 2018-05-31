using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void SellProduct(ProductDto product, int count, DateTime dateCreate)
        {
            _repository.SellProduct(product, count, dateCreate);
        }

        public List<ProductDto> GetTopProduct(int top)
        {
            return _repository.GetTopProduct(top);
        }

        public List<ProductDto> GetAllProduct()
        {
            return _repository.GetAll();
        }

        public ProductDto GetProductByID(int ID)
        {
            return _repository.GetProduct(ID);
        }

        public void ExportToCsv(List<ProductDto> products, string fileName)
        {
            _repository.ExportToCsvFile(products, fileName);
        }

        public List<ProductStatusDto> GetAllProductStatus(string key1, string key2 = "", string key3 = "")
        {
            return Helper.GetMasterData<ProductStatusDto>(key1, key2, key3);
        }

        public List<ProductTypeDto> GetAllProductType(string key1, string key2 = "", string key3 = "")
        {
            return Helper.GetMasterData<ProductTypeDto>(key1, key2, key3);
        }

        public List<ProductDto> GetTopVehicles(int top)
        {
            return _repository.GetTopVehicles(top);
        }

        public void EditVehicle(ProductDto vehicle)
        {
            _repository.EditVehicle(vehicle);
        }
    }
}
