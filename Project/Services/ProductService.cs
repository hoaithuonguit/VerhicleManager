using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
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
        public void AddProduct(ProductDto product)
        {
            _repository.AddProduct(product);
        }

        public void ImportProduct(ProductDto product, int count)
        {
            _repository.ImportProduct(product, count);
        }

        public void SellProduct(ProductDto product, int count)
        {
            _repository.SellProduct(product, count);
        }

        public List<ProductDto> GetTopProduct(int range)
        {
            return _repository.GetTopProduct(range);
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
    }
}
