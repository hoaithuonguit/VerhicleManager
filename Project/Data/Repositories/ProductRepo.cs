using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using Data.Dtos;
using Data.Model;
using Data.Infrastructure;

namespace Data.Repositories
{
    public class ProductRepo : IProductRepo
    {
        public ProductRepo()
        {
        }

        public string AddProduct(ProductDto product, string type)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    var checkIfExists = (from p in dbContext.SanPhams
                                         where p.Ten.ToUpper().Equals(product.Ten.ToUpper())
                                         select p.ID).Count();

                    if (checkIfExists > 0)
                        return Constant.MESSAGE_ERROR;
                    var getCount = (from p in dbContext.SanPhams select p.ID).Count();
                    int ID = getCount + 1;
                    dbContext.SanPhams.Add(new SanPham()
                    {
                        Loai = type,
                        Ten = product.Ten,
                        ID = ID
                    });

                    ThongTinSanPham productInfomation = new ThongTinSanPham()
                    {
                        Hieu = product.Hieu,
                        Doi = product.Doi,
                        Hang = product.Hang,
                        MoTa = product.MoTa,
                        TinhTrang = product.TinhTrang,
                        PhanLoai = product.PhanLoai,
                        ID = ID
                    };
                    dbContext.ThongTinSanPhams.Add(productInfomation);

                    dbContext.SaveChanges();
                    return Constant.MESSAGE_SUCCESS;

                }
            }
            // CATCH EXEPTION FOR DEBUG PURPOSE
            catch (DbEntityValidationException ex)
            {
                foreach (var e in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        e.Entry.Entity.GetType().Name, e.Entry.State);
                    foreach (var ve in e.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }

                return Constant.MESSAGE_ERROR;
            }
            catch (DbUpdateException ex)
            {
                return Constant.MESSAGE_ERROR;
            }

        }

        public string ImportProduct(ImportProductDto importInformation, DateTime dateCreate)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    dbContext.NhapHangs.Add(new NhapHang()
                    {
                        NgayNhapHang = dateCreate,
                        ID_Product = importInformation.ID_Product,
                        SoLuong = importInformation.Quantities,
                        TinhTrang = importInformation.Status,
                        Hang = importInformation.Label,
                        PhanLoaiXe = importInformation.Classification,
                        MoTa = importInformation.Description,
                        Loai = importInformation.Category,
                        ID = (from s in dbContext.NhapHangs select s.ID).Count() + 1
                    });

                    var thisProductInStock = dbContext.Khoes.Where(p => p.ID == importInformation.ID_Product)
                        .DefaultIfEmpty(null)
                        .FirstOrDefault();
                    if (thisProductInStock == null)
                    {
                        dbContext.Khoes.Add(new Kho()
                        {
                            ID = importInformation.ID_Product,
                            NgayUpdated = dateCreate,
                            SoLuong = importInformation.Quantities
                        });
                    }
                    else
                    {
                        thisProductInStock.SoLuong += importInformation.Quantities;
                    }

                    dbContext.SaveChanges();

                    return Constant.MESSAGE_SUCCESS;
                }
            }
            // CATCH EXEPTION FOR DEBUG PURPOSE
            catch (DbEntityValidationException ex)
            {
                foreach (var e in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        e.Entry.Entity.GetType().Name, e.Entry.State);
                    foreach (var ve in e.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }

                return Constant.MESSAGE_ERROR;
            }
            catch (DbUpdateException ex)
            {
                return Constant.MESSAGE_ERROR;
            }
        }

        #region QueryMethod

        public List<ProductDto> GetTopAccessories(int top)
        {
            using (var dbContext = new XeNangEntities())
            {
                var date = DateTime.Now.AddDays(-7).Date;
                var resultQuery = ((from b in dbContext.BanHangs
                                    join p in dbContext.SanPhams on b.ID_Product equals p.ID
                                    join d in dbContext.ThongTinSanPhams on p.ID equals d.ID
                                    where b.NgayBan > date
                                    select new
                                    {
                                        Product = new
                                        {
                                            p.ID,
                                            p.Ten,
                                            p.Loai,
                                            d.Hieu,
                                            d.Doi,
                                            d.Hang,
                                            d.MoTa,
                                            d.TinhTrang,
                                            d.PhanLoai                                        
                                        },
                                        Quantity = b.SoLuong
                                    }
                    into productQuantity
                                    group productQuantity by productQuantity.Product
                    into pg
                                    let total = pg.Sum(prod => prod.Quantity)
                                    orderby total descending
                                    select new ProductDto()
                                    {
                                        ID = pg.Key.ID,
                                        Ten = pg.Key.Ten,
                                        Loai = pg.Key.Loai,
                                        Hieu = pg.Key.Hieu,
                                        Doi = pg.Key.Doi,
                                        Hang = pg.Key.Hang,
                                        MoTa = pg.Key.MoTa,
                                        TinhTrang = pg.Key.TinhTrang,
                                        PhanLoai = pg.Key.PhanLoai                                      
                                    }).Take(top)).ToList<ProductDto>();

                var result = (from p in resultQuery
                              select new ProductDto()
                              {
                                  ID = p.ID,
                                  Ten = p.Ten,
                                  Loai = Helper.GetTypeName(p.Loai),
                                  Hieu = p.Hieu,
                                  Hang = p.Hang,
                                  Doi = p.Doi,
                                  MoTa = p.MoTa,
                                  TinhTrang = Helper.GetValueFromNameInMaster(p.TinhTrang),
                                  PhanLoai = Helper.GetValueFromNameInMaster(p.PhanLoai)
                              }).ToList<ProductDto>();

                if (result.Count > 0)
                    return result;
                return new List<ProductDto>();
            }
        }

        public List<ProductDto> GetTopVehicles(int top)
        {
            using (var dbContext = new XeNangEntities())
            {
                var resultQuery = ((from b in dbContext.BanHangs
                                    join p in dbContext.SanPhams on b.ID_Product equals p.ID
                                    join d in dbContext.ThongTinSanPhams on p.ID equals d.ID
                                    where p.Loai.Equals(Constant.TYPE_VEHICLE)
                                    select new
                                    {
                                        Product = new
                                        {
                                            p.ID,
                                            p.Ten,
                                            p.Loai,
                                            d.Hieu,
                                            d.Doi,
                                            d.Hang,
                                            d.MoTa,
                                            d.TinhTrang,
                                            d.PhanLoai
                                        },
                                        Quantity = b.SoLuong
                                    }
                    into productQuantity
                                    group productQuantity by productQuantity.Product
                    into pg
                                    let total = pg.Sum(prod => prod.Quantity)
                                    orderby total descending
                                    select new ProductDto()
                                    {
                                        ID = pg.Key.ID,
                                        Ten = pg.Key.Ten,
                                        Loai = pg.Key.Loai,
                                        Hieu = pg.Key.Hieu,
                                        Doi = pg.Key.Doi,
                                        Hang = pg.Key.Hang,
                                        MoTa = pg.Key.MoTa,
                                        TinhTrang = pg.Key.TinhTrang,
                                        PhanLoai = pg.Key.PhanLoai
                                    }).Take(top)).ToList<ProductDto>();

                var result = (from p in resultQuery
                              select new ProductDto()
                              {
                                  ID = p.ID,
                                  Ten = p.Ten,
                                  Loai = Helper.GetTypeName(p.Loai),
                                  Hieu = p.Hieu,
                                  Hang = p.Hang,
                                  Doi = p.Doi,
                                  MoTa = p.MoTa,
                                  TinhTrang = Helper.GetValueFromNameInMaster(p.TinhTrang),
                                  PhanLoai = Helper.GetValueFromNameInMaster(p.PhanLoai)                                 
                              }).ToList<ProductDto>();

                if (result.Count > 0)
                    return result;
                return new List<ProductDto>();
            }
        }

        public List<ImportProductDto> GetImportInformation()
        {
            using (var dbContext = new XeNangEntities())
            {
                var result_query = (from i in dbContext.NhapHangs
                                    join p in dbContext.SanPhams on i.ID_Product equals p.ID
                                    select new ImportProductDto()
                                    {
                                        ID = i.ID,
                                        ID_Product = i.ID_Product,
                                        ProductName = p.Ten,
                                        Quantities = i.SoLuong,
                                        DateCreate = i.NgayNhapHang,
                                        Classification = i.PhanLoaiXe,
                                        Status = i.TinhTrang,
                                        Description = i.MoTa,
                                        Category = p.Loai
                                    }).ToList<ImportProductDto>();

                var result = (from r in result_query
                              select new ImportProductDto()
                              {
                                  ID = r.ID,
                                  ID_Product = r.ID_Product,
                                  ProductName = r.ProductName,
                                  Quantities = r.Quantities,
                                  DateCreate = r.DateCreate,
                                  Classification = Helper.GetValueFromNameInMaster(r.Classification),
                                  Status = Helper.GetValueFromNameInMaster(r.Status),
                                  Description = r.Description,
                                  Category = Helper.GetTypeName(r.Category)
                              }).ToList<ImportProductDto>();

                if (result.Count > 0)
                    return result;
                return new List<ImportProductDto>();

            }


        }

        public List<SellProductDto> GetSellInformation()
        {
            using (var dbContext = new XeNangEntities())
            {
                var result_query = (from s in dbContext.BanHangs
                                    join p in dbContext.SanPhams on s.ID_Product equals p.ID
                                    select new SellProductDto()
                                    {
                                        ID = s.ID,
                                        ID_Product = s.ID_Product,
                                        ProductName = p.Ten,
                                        Category = p.Loai,
                                        DateOfSale = s.NgayBan,
                                        Quantities = s.SoLuong
                                    }).ToList<SellProductDto>();

                var result = (from r in result_query
                              select new SellProductDto()
                              {
                                  ID = r.ID,
                                  ID_Product = r.ID_Product,
                                  ProductName = r.ProductName,
                                  Category = Helper.GetTypeName(r.Category),
                                  DateOfSale = r.DateOfSale,
                                  Quantities = r.Quantities
                              }).ToList<SellProductDto>();

                if (result.Count > 0)
                    return result;
                return new List<SellProductDto>();
            }
        }

        public List<StockDto> GetStockInformation()
        {
            using (var dbContext = new XeNangEntities())
            {
                var result_query = (from s in dbContext.Khoes
                                    join p in dbContext.SanPhams on s.ID equals p.ID
                                    select new StockDto()
                                    {
                                        ID = s.ID,
                                        Category = p.Loai,
                                        Inventories = s.SoLuong,
                                        LastUpdate = s.NgayUpdated,
                                        ProductName = p.Ten
                                    }).ToList<StockDto>();

                var result = (from r in result_query
                              select new StockDto()
                              {
                                  ID = r.ID,
                                  Category = Helper.GetTypeName(r.Category),
                                  Inventories = r.Inventories,
                                  LastUpdate = r.LastUpdate,
                                  ProductName = r.ProductName
                              }).ToList<StockDto>();

                if (result.Count > 0)
                    return result;
                return new List<StockDto>();
            }
        }

        public List<StockDto> GetStockInformation(int top)
        {
            using (var dbContext = new XeNangEntities())
            {
                var date = DateTime.Now.AddDays(-7).Date;
                var result_query = ((from b in dbContext.BanHangs
                                     join s in dbContext.Khoes on b.ID_Product equals s.ID
                                     join p in dbContext.SanPhams on s.ID equals p.ID
                                     where b.NgayBan > date
                                     select new
                                     {
                                         Product = new
                                         {
                                             s.ID,
                                             Category = p.Loai,
                                             Inventories = s.SoLuong,
                                             LastUpdate = s.NgayUpdated,
                                             ProductName = p.Ten
                                         },
                                         Quantities = b.SoLuong
                                     }
                    into productQuantity
                                     group productQuantity by productQuantity.Product
                    into pg
                                     let total = pg.Sum(prod => prod.Quantities)
                                     orderby total descending
                                     select new StockDto()
                                     {
                                         ID = pg.Key.ID,
                                         Category = pg.Key.Category,
                                         Inventories = pg.Key.Inventories,
                                         LastUpdate = pg.Key.LastUpdate,
                                         ProductName = pg.Key.ProductName,

                                     }).Take(top)).ToList<StockDto>();

                var result = (from r in result_query
                              select new StockDto()
                              {
                                  ID = r.ID,
                                  Category = Helper.GetTypeName(r.Category),
                                  Inventories = r.Inventories,
                                  LastUpdate = r.LastUpdate,
                                  ProductName = r.ProductName
                              }).ToList<StockDto>();

                if (result.Count > 0)
                    return result;
                return new List<StockDto>();

            }
        }

        public List<ProductDto> GetAll(string type)
        {
            using (var dbContext = new XeNangEntities())
            {
                var resultQuery = (from p in dbContext.SanPhams
                                   join d in dbContext.ThongTinSanPhams on p.ID equals d.ID
                                   where p.Loai.Equals(type)
                                   select new ProductDto()
                                   {
                                       ID = p.ID,
                                       Ten = p.Ten,
                                       Loai = p.Loai,
                                       Hieu = d.Hieu,
                                       Hang = d.Hang,
                                       Doi = d.Doi,
                                       MoTa = d.MoTa,
                                       TinhTrang = d.TinhTrang,
                                       PhanLoai = d.PhanLoai
                                   }).ToList<ProductDto>();

                var result = (from p in resultQuery
                              select new ProductDto()
                              {
                                  ID = p.ID,
                                  Ten = p.Ten,
                                  Loai = Helper.GetTypeName(p.Loai),
                                  Hieu = p.Hieu,
                                  Hang = p.Hang,
                                  Doi = p.Doi,
                                  MoTa = p.MoTa,
                                  TinhTrang = Helper.GetValueFromNameInMaster(p.TinhTrang),
                                  PhanLoai = Helper.GetValueFromNameInMaster(p.PhanLoai),
                                  Image1 = p.Image1,
                                  Image2 = p.Image2,
                                  Image3 = p.Image3,
                                  Image4 = p.Image4,
                                  Image5 = p.Image5,
                              }).ToList<ProductDto>();
                if (result.Count > 0)
                    return result;
                return new List<ProductDto>();
            }
        }

        public string[] GetAllProductName()
        {
            using (var dbContext = new XeNangEntities())
            {
                var result = (from p in dbContext.SanPhams
                              select p.Ten).ToArray();
                if (result.Length > 0)
                    return result;
                return new string[] { };
            }
        }

        public string[] GetAllProductName(string type)
        {
            using (var dbContext = new XeNangEntities())
            {
                var result = (from p in dbContext.SanPhams
                              where (p.Loai.Equals(type))
                              select p.Ten).ToArray();
                if (result.Length > 0)
                    return result;
                return new string[] { };
            }
        }

        public ProductDto GetProduct(int id, string type)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    var result = (from p in dbContext.SanPhams
                                  join d in dbContext.ThongTinSanPhams on p.ID equals d.ID
                                  where p.ID.Equals(id) && p.Loai.Equals(type)
                                  select new ProductDto()
                                  {
                                      ID = id,
                                      Ten = p.Ten,
                                      Loai = p.Loai,
                                      Doi = d.Doi,
                                      Hang = d.Hang,
                                      Hieu = d.Hieu,
                                      TinhTrang = d.TinhTrang,
                                      PhanLoai = d.PhanLoai,
                                      MoTa = d.MoTa,
                                  }).FirstOrDefault();
                    result.Loai = Helper.GetTypeName(result.Loai);
                    result.TinhTrang = Helper.GetValueFromNameInMaster(result.TinhTrang);
                    result.PhanLoai = Helper.GetValueFromNameInMaster(result.PhanLoai);
                    return result;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<OrderDetailDto> GetAllOrdersAreWaiting()
        {
            using (var dbContext = new XeNangEntities())
            {
                var resultQuery = (from o in dbContext.DatHangs
                                   where o.TrangThai.Equals(Constant.STATUS_WAITING)
                                   select new OrderDetailDto()
                                   {
                                       CustomerAddr = o.DiaChi,
                                       CustomerEmail = o.MailZalo,
                                       CustomerName = o.TenNguoiDat,
                                       CustomerPhoneNo = o.SDT,
                                       DateOfDelivery = o.ThoiGianCanLay,
                                       Description = o.MoTa,
                                       ID = o.ID,
                                       ProductName = o.TenHang,
                                       Quantities = o.SoLuong,
                                       Status = o.TrangThai
                                   }).ToList<OrderDetailDto>();

                var result = (from p in resultQuery
                              select new OrderDetailDto()
                              {
                                  CustomerAddr = p.CustomerAddr,
                                  CustomerEmail = p.CustomerEmail,
                                  CustomerName = p.CustomerName,
                                  CustomerPhoneNo = p.CustomerPhoneNo,
                                  DateOfDelivery = p.DateOfDelivery,
                                  Description = p.Description,
                                  ID = p.ID,
                                  ProductName = p.ProductName,
                                  Quantities = p.Quantities,
                                  Status = Helper.GetStatus(p.Status)
                              }).ToList<OrderDetailDto>();

                if (result.Count > 0)
                    return result;

                return new List<OrderDetailDto>();
            }
        }

        public List<OrderDetailDto> GetAllOrdersAreCensorred()
        {
            using (var dbContext = new XeNangEntities())
            {
                var resultQuery = (from o in dbContext.DatHangs
                                   where o.TrangThai.Equals(Constant.STATUS_CENSORRED)
                                   select new OrderDetailDto()
                                   {
                                       CustomerAddr = o.DiaChi,
                                       CustomerEmail = o.MailZalo,
                                       CustomerName = o.TenNguoiDat,
                                       CustomerPhoneNo = o.SDT,
                                       DateOfDelivery = o.ThoiGianCanLay,
                                       Description = o.MoTa,
                                       ID = o.ID,
                                       ProductName = o.TenHang,
                                       Quantities = o.SoLuong,
                                       Status = o.TrangThai
                                   }).ToList<OrderDetailDto>();


                var result = (from p in resultQuery
                              select new OrderDetailDto()
                              {
                                  CustomerAddr = p.CustomerAddr,
                                  CustomerEmail = p.CustomerEmail,
                                  CustomerName = p.CustomerName,
                                  CustomerPhoneNo = p.CustomerPhoneNo,
                                  DateOfDelivery = p.DateOfDelivery,
                                  Description = p.Description,
                                  ID = p.ID,
                                  ProductName = p.ProductName,
                                  Quantities = p.Quantities,
                                  Status = Helper.GetStatus(p.Status)
                              }).ToList<OrderDetailDto>();


                if (result.Count > 0)
                    return result;

                return new List<OrderDetailDto>();
            }
        }

        public List<StockDto> GetStockInformationWithType(string type)
        {
            using (var dbContext = new XeNangEntities())
            {
                var result_query = (from s in dbContext.Khoes
                                    join p in dbContext.SanPhams on s.ID equals p.ID
                                    where p.Loai.Equals(type)
                                    select new StockDto()
                                    {
                                        ID = s.ID,
                                        Category = p.Loai,
                                        Inventories = s.SoLuong,
                                        LastUpdate = s.NgayUpdated,
                                        ProductName = p.Ten
                                    }).ToList<StockDto>();

                var result = (from r in result_query
                              select new StockDto()
                              {
                                  ID = r.ID,
                                  Category = Helper.GetTypeName(r.Category),
                                  Inventories = r.Inventories,
                                  LastUpdate = r.LastUpdate,
                                  ProductName = r.ProductName
                              }).ToList<StockDto>();

                if (result.Count > 0)
                    return result;
                return new List<StockDto>();
            }
        }

        public List<StockDto> GetStockInformationOfProduct(int ID)
        {
            using (var dbContext = new XeNangEntities())
            {
                var resultQuery = (from s in dbContext.Khoes
                                   join p in dbContext.SanPhams on s.ID equals p.ID
                                   where p.ID.Equals(ID)
                                   select new StockDto()
                                   {
                                       ID = s.ID,
                                       Category = p.Loai,
                                       Inventories = s.SoLuong,
                                       LastUpdate = s.NgayUpdated,
                                       ProductName = p.Ten
                                   }).ToList();

                var result = (from s in resultQuery
                              select new StockDto()
                              {
                                  ID = s.ID,
                                  Category = Helper.GetTypeName(s.Category),
                                  Inventories = s.Inventories,
                                  LastUpdate = s.LastUpdate,
                                  ProductName = s.ProductName
                              }).ToList();

                return result;
            }
        }
        #endregion

        public bool ExportToCsvFile(List<ProductDto> products, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Tên,Loại,Hiệu,Đời,Hãng,Mô tả,Tình trạng,Phân loại");
                    foreach (var p in products)
                    {
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", p.Ten, p.Loai, p.Hieu, p.Doi,
                            p.Hang, p.MoTa, p.TinhTrang, p.PhanLoai));
                    }

                    sw.Write(sb.ToString());
                    return true;
                }
            }
            // CATCH EXEPTION FOR DEBUG PURPOSE
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ExportToCsvFile(List<ImportProductDto> importProduct, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Tên,Loại,Ngày nhập,Số lượng,Trạng thái,Hãng,Phân loại,Mô tả");
                    foreach (var p in importProduct)
                    {
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", p.ProductName, p.Category, p.DateCreate.ToString("dd-MM-yyyy"), p.Quantities,
                            p.Status, p.Label, p.Classification, p.Description
                            ));
                    }

                    sw.Write(sb.ToString());
                    return true;
                }
            }
            // CATCH EXEPTION FOR DEBUG PURPOSE
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ExportToCsvFile(List<OrderDetailDto> orderDetail, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Ngày đặt,Tên KH,Địa chỉ,SĐT,Email,Tên sản phẩm,Số lượng,Ngày lấy,Mô tả, Trạng thái");
                    foreach (var p in orderDetail)
                    {
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                            p.DateCreate.ToString("dd-MM-yyyy"), p.CustomerName, p.CustomerAddr, p.CustomerPhoneNo,
                            p.CustomerEmail, p.ProductName, p.Quantities, p.DateOfDelivery.ToString("dd-MM-yyyy"),
                            p.Description, p.Status));
                    }

                    sw.Write(sb.ToString());
                    return true;
                }
            }
            // CATCH EXEPTION FOR DEBUG PURPOSE
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ExportToCsvFile(List<SellProductDto> sellProduct, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Tên sản phẩm,Loại,Số lượng,Ngày bán");
                    foreach (var p in sellProduct)
                    {
                        sb.AppendLine(string.Format("{0},{1},{2},{3}", p.ProductName, p.Category, p.Quantities, p.DateOfSale.ToString("dd-MM-yyyy")));
                    }

                    sw.Write(sb.ToString());
                    return true;
                }
            }
            // CATCH EXEPTION FOR DEBUG PURPOSE
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ExportToCsvFile(List<StockDto> stock, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Tên sản phẩm,Loại,Số lượng tồn,Ngày cập nhật");
                    foreach (var p in stock)
                    {
                        sb.AppendLine(string.Format("{0},{1},{2},{3}", p.ProductName, p.Category, p.Inventories, p.LastUpdate.ToString("dd-MM-yyyy")));
                    }

                    sw.Write(sb.ToString());
                    return true;
                }
            }
            // CATCH EXEPTION FOR DEBUG PURPOSE
            catch (Exception e)
            {
                return false;
            }
        }

        public bool EditVehicle(ProductDto vehicle)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    var product = (from p in dbContext.SanPhams
                                   where p.ID.Equals(vehicle.ID)
                                   select p).FirstOrDefault();
                    if (product == null) return false;
                    product.Ten = vehicle.Ten;
                    product.Loai = vehicle.Loai;

                    var productInformation = (from i in dbContext.ThongTinSanPhams
                                              where i.ID.Equals(vehicle.ID)
                                              select i).FirstOrDefault();

                    if (productInformation == null) return false;

                    productInformation.Hieu = vehicle.Hieu;
                    productInformation.Doi = vehicle.Doi;
                    productInformation.Hang = vehicle.Hang;
                    productInformation.MoTa = vehicle.MoTa;
                    productInformation.TinhTrang = vehicle.TinhTrang;
                    productInformation.PhanLoai = vehicle.PhanLoai;

                    dbContext.SaveChanges();
                    return true;
                }
            }

            // CATCH EXEPTION FOR DEBUG PURPOSE
            catch (DbEntityValidationException ex)
            {
                foreach (var e in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        e.Entry.Entity.GetType().Name, e.Entry.State);
                    foreach (var ve in e.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }

                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }

        public string SellProduct(SellProductDto sellInformation, DateTime dateCreate)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    var productInStock = (dbContext.Khoes.First(p => p.ID == sellInformation.ID_Product));
                    if (productInStock.SoLuong < sellInformation.Quantities)
                        return Constant.MESSAGE_ERROR;

                    dbContext.BanHangs.Add(new BanHang()
                    {
                        ID_Product = sellInformation.ID_Product,
                        NgayBan = dateCreate,
                        SoLuong = sellInformation.Quantities,
                        ID = (from s in dbContext.BanHangs select s.ID).Count() + 1
                    });

                    productInStock.NgayUpdated = dateCreate;
                    productInStock.SoLuong -= sellInformation.Quantities;
                    dbContext.SaveChanges();
                    return Constant.MESSAGE_SUCCESS;
                }
            }
            // CATCH EXEPTION FOR DEBUG PURPOSE
            catch (DbEntityValidationException ex)
            {
                foreach (var e in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        e.Entry.Entity.GetType().Name, e.Entry.State);
                    foreach (var ve in e.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }

                return Constant.MESSAGE_ERROR;
            }
            catch (DbUpdateException ex)
            {
                return Constant.MESSAGE_ERROR;
            }
        }

        public string OrderProduct(OrderDetailDto order, DateTime dateCreate)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    int ID = (from o in dbContext.DatHangs select o.ID).Count() + 1;
                    var or = new DatHang()
                    {
                        ID = ID,
                        DiaChi = order.CustomerAddr,
                        MailZalo = order.CustomerEmail,
                        //CreateDt = dateCreate,
                        SDT = order.CustomerPhoneNo,
                        SoLuong = order.Quantities,
                        TenHang = order.ProductName,
                        TenNguoiDat = order.CustomerName,
                        ThoiGianCanLay = order.DateOfDelivery,
                        TrangThai = order.Status,
                    };
                    if (order.Description != null) or.MoTa = order.Description;
                    dbContext.DatHangs.Add(or);
                    dbContext.SaveChanges();

                    return Constant.MESSAGE_SUCCESS;
                }
            }
            // CATCH EXEPTION FOR DEBUG PURPOSE
            catch (DbEntityValidationException ex)
            {
                foreach (var e in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        e.Entry.Entity.GetType().Name, e.Entry.State);
                    foreach (var ve in e.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }

                return Constant.MESSAGE_ERROR;
            }
            catch (DbUpdateException ex)
            {
                return Constant.MESSAGE_ERROR;
            }
        }

        public string ChangeStatusOfOrder(int orderId, string status)
        {
            using (var dbContext = new XeNangEntities())
            {
                var result = (from o in dbContext.DatHangs
                              where o.ID.Equals(orderId)
                              select o).FirstOrDefault();
                if (result == null)
                    return Constant.MESSAGE_ERROR;
                result.TrangThai = status;
                dbContext.SaveChanges();
                return Constant.MESSAGE_SUCCESS;
            }
        }

    }
}
