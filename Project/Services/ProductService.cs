using System;
using System.Collections.Generic;
using Data.Dtos;
using Data.Infrastructure;
using Data.Repositories;
using Services.Abstract;
using System.Web;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI.HtmlControls;

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
            // TODO replace this path with absolute path of your PC
            string path = @"E:\Project\VehicleManager\Project\website\Image";

            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)
            {
                string img1 = Path.GetFileName(product.Image1);
                string desImg1 = Path.Combine(path, img1);
                if (!File.Exists(desImg1))
                    File.Copy(product.Image1, desImg1, true);
                product.Image1 = desImg1;

                if (product.Image2 != null)
                {
                    string img2 = Path.GetFileName(product.Image2);
                    string desImg2 = Path.Combine(path, img2);
                    if (!File.Exists(desImg2))
                        File.Copy(product.Image2, desImg2, true);
                    product.Image2 = desImg2;
                }
                if (product.Image3 != null)
                {
                    string img3 = Path.GetFileName(product.Image3);
                    string desImg3 = Path.Combine(path, img3);
                    if (!File.Exists(desImg3))
                        File.Copy(product.Image3, desImg3, true);
                    product.Image3 = desImg3;
                }
                if (product.Image4 != null)
                {
                    string img4 = Path.GetFileName(product.Image4);
                    string desImg4 = Path.Combine(path, img4);
                    if (!File.Exists(desImg4))
                        File.Copy(product.Image4, desImg4, true);
                    product.Image4 = desImg4;
                }
                if (product.Image5 != null)
                {
                    string img5 = Path.GetFileName(product.Image5);
                    string desImg5 = Path.Combine(path, img5);
                    if (!File.Exists(desImg5))
                        File.Copy(product.Image5, desImg5, true);
                    product.Image5 = desImg5;
                }
            }

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
        public string GetTitleStore()
        {
            return Helper.GetTitleStore();
        }
        public string GetAddressStore()
        {
            return Helper.GetAddrStore();
        }
        public void SetStoreInformation(string name, string title, string address)
        {
            Helper.SetStoreInformation(name, title, address);
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

        public List<StockDto> LoadStockInformation(int top)
        {
            return _repository.GetStockInformation(top);
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
