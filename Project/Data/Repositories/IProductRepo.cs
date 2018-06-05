using System;
using System.Collections.Generic;
using Data.Dtos;

namespace Data.Repositories
{
    public interface IProductRepo
    {
        /// <summary>
        /// Add new Product (can be a vehicle or an accessory) to database
        /// </summary>
        /// <param name="product">Information of product</param>
        /// <param name="type"> Constant.TYPE_VEHICLE = "01" or Constant.TYPE_ACCESSORY = "02"</param>
        /// <returns>Constant.MESSAGE_SUCCESS if add product success or Constant.MESSAGE_ERROR if error occur</returns>
        string AddProduct(ProductDto product, string type);
        string ImportProduct(ProductDto product, int count, DateTime dateCreate);
        List<ProductDto> GetTopAccessories(int top);
        List<ProductDto> GetAll(string type);
        bool ExportToCsvFile(List<ProductDto> products, string fileName);
        ProductDto GetProduct(int id, string type);
        bool EditVehicle(ProductDto vehicle);
        List<ProductDto> GetTopVehicles(int top);
        
    }
}
