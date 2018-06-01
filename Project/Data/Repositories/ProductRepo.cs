using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        #region AddingMethod
        public bool AddProduct(ProductDto product, string type)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    var checkIfExists = (from p in dbContext.SanPhams
                                         where p.Ten.ToUpper().Equals(product.Ten.ToUpper())
                                         select p.ID).Count();

                    if (checkIfExists > 0)
                        return false;
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
                        Image1 = product.Image1,
                        ID = ID
                    };
                    if (product.Image2 != null) productInfomation.Image2 = product.Image2;
                    if (product.Image3 != null) productInfomation.Image2 = product.Image3;
                    if (product.Image4 != null) productInfomation.Image2 = product.Image4;
                    if (product.Image5 != null) productInfomation.Image2 = product.Image5;
                    dbContext.ThongTinSanPhams.Add(productInfomation);

                    dbContext.SaveChanges();
                    return true;

                }
            }
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
        public bool AddNewProduct(ProductDto product, string type)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    var checkIfExists = (from p in dbContext.SanPhams
                                         where p.Ten.ToUpper().Equals(product.Ten.ToUpper())
                                         select p.ID).Count();

                    if (checkIfExists > 0)
                        return false;
                    var getCount = (from p in dbContext.SanPhams select p.ID).Count();
                    int ID = getCount + 1;
                    dbContext.SanPhams.Add(new SanPham()
                    {
                        Loai = type,
                        Ten = product.Ten,
                        ID = ID
                    });

                    return true;
                }
            }
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
        public bool AddProductInformation(ProductDto productInfo)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {

                    ThongTinSanPham productInfomation = new ThongTinSanPham()
                    {
                        Hieu = productInfo.Hieu,
                        Doi = productInfo.Doi,
                        Hang = productInfo.Hang,
                        MoTa = productInfo.MoTa,
                        TinhTrang = productInfo.TinhTrang,
                        PhanLoai = productInfo.PhanLoai,
                        Image1 = productInfo.Image1,
                        ID = productInfo.ID
                    };
                    if (productInfo.Image2 != null) productInfomation.Image2 = productInfo.Image2;
                    if (productInfo.Image3 != null) productInfomation.Image2 = productInfo.Image3;
                    if (productInfo.Image4 != null) productInfomation.Image2 = productInfo.Image4;
                    if (productInfo.Image5 != null) productInfomation.Image2 = productInfo.Image5;
                    dbContext.ThongTinSanPhams.Add(productInfomation);

                    dbContext.SaveChanges();
                    return true;

                }
            }
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
        #endregion

        public bool ImportProduct(ProductDto product, int count, DateTime dateCreate)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    dbContext.NhapHangs.Add(new NhapHang()
                    {
                        NgayNhapHang = dateCreate,
                        ID_Product = product.ID,
                        SoLuong = count,
                        TinhTrang = product.TinhTrang,
                        Hang = product.Hang,
                        PhanLoaiXe = product.PhanLoai,
                        MoTa = product.MoTa,
                        Loai = product.Loai,
                        ID = (from s in dbContext.NhapHangs select s.ID).Count()
                    });

                    var thisProductInStock = dbContext.Khoes.Where(p => p.ID == product.ID).DefaultIfEmpty(null)
                        .FirstOrDefault();
                    if (thisProductInStock == null)
                    {
                        dbContext.Khoes.Add(new Kho()
                        {
                            ID = product.ID,
                            NgayUpdated = dateCreate,
                            SoLuong = count
                        });
                    }
                    else
                    {
                        thisProductInStock.SoLuong += count;
                    }

                    dbContext.SaveChanges();

                    return true;
                }
            }
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

        public bool SellProduct(ProductDto product, int count, DateTime dateCreate)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    var productInStock = (dbContext.Khoes.First(p => p.ID == product.ID));
                    if (productInStock.SoLuong < count)
                        return false;

                    dbContext.BanHangs.Add(new BanHang()
                    {
                        ID_Product = product.ID,
                        NgayBan = dateCreate,
                        SoLuong = count,
                        ID = (from s in dbContext.BanHangs select s.ID).Count()
                    });

                    productInStock.NgayUpdated = dateCreate;
                    productInStock.SoLuong -= count;
                    dbContext.SaveChanges();
                    return true;
                }
            }
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
                                            d.PhanLoai,
                                            d.Image1,
                                            d.Image2,
                                            d.Image3,
                                            d.Image4,
                                            d.Image5
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
                                        PhanLoai = pg.Key.PhanLoai,
                                        Image1 = pg.Key.Image1,
                                        Image2 = pg.Key.Image2,
                                        Image3 = pg.Key.Image3,
                                        Image4 = pg.Key.Image4,
                                        Image5 = pg.Key.Image5
                                    }).Take(top)).ToList<ProductDto>();

                var result = (from p in resultQuery
                              select new ProductDto()
                              {
                                  ID = p.ID,
                                  Ten = p.Ten,
                                  Loai = Helper.CheckType(p.Loai),
                                  Hieu = p.Hieu,
                                  Hang = p.Hang,
                                  Doi = p.Doi,
                                  MoTa = p.MoTa,
                                  TinhTrang = Helper.GetStatusValue(p.TinhTrang),
                                  PhanLoai = Helper.GetCategoryValue(p.PhanLoai),
                                  Image1 = p.Image1,
                                  Image2 = p.Image2,
                                  Image3 = p.Image3,
                                  Image4 = p.Image4,
                                  Image5 = p.Image5,
                              }).ToList<ProductDto>();


                return result;
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
                                            d.PhanLoai,
                                            d.Image1,
                                            d.Image2,
                                            d.Image3,
                                            d.Image4,
                                            d.Image5
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
                                        PhanLoai = pg.Key.PhanLoai,
                                        Image1 = pg.Key.Image1,
                                        Image2 = pg.Key.Image2,
                                        Image3 = pg.Key.Image3,
                                        Image4 = pg.Key.Image4,
                                        Image5 = pg.Key.Image5
                                    }).Take(top)).ToList<ProductDto>();

                var result = (from p in resultQuery
                              select new ProductDto()
                              {
                                  ID = p.ID,
                                  Ten = p.Ten,
                                  Loai = Helper.CheckType(p.Loai),
                                  Hieu = p.Hieu,
                                  Hang = p.Hang,
                                  Doi = p.Doi,
                                  MoTa = p.MoTa,
                                  TinhTrang = Helper.GetStatusValue(p.TinhTrang),
                                  PhanLoai = Helper.GetCategoryValue(p.PhanLoai),
                                  Image1 = p.Image1,
                                  Image2 = p.Image2,
                                  Image3 = p.Image3,
                                  Image4 = p.Image4,
                                  Image5 = p.Image5,
                              }).ToList<ProductDto>();


                return result;
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
                                       PhanLoai = d.PhanLoai,
                                       Image1 = d.Image1,
                                       Image2 = d.Image2,
                                       Image3 = d.Image3,
                                       Image4 = d.Image4,
                                       Image5 = d.Image5,
                                   }).ToList<ProductDto>();

                var result = (from p in resultQuery
                              select new ProductDto()
                              {
                                  ID = p.ID,
                                  Ten = p.Ten,
                                  Loai = Helper.CheckType(p.Loai),
                                  Hieu = p.Hieu,
                                  Hang = p.Hang,
                                  Doi = p.Doi,
                                  MoTa = p.MoTa,
                                  TinhTrang = Helper.GetStatusValue(p.TinhTrang),
                                  PhanLoai = Helper.GetCategoryValue(p.PhanLoai),
                                  Image1 = p.Image1,
                                  Image2 = p.Image2,
                                  Image3 = p.Image3,
                                  Image4 = p.Image4,
                                  Image5 = p.Image5,
                              }).ToList<ProductDto>();

                return result;
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
                                      Image1 = d.Image1,
                                      Image2 = d.Image2,
                                      Image3 = d.Image3,
                                      Image4 = d.Image4,
                                      Image5 = d.Image5,
                                      MoTa = d.MoTa,
                                  }).FirstOrDefault();
                    result.Loai = Helper.CheckType(result.Loai);
                    result.TinhTrang = Helper.GetStatusValue(result.TinhTrang);
                    result.PhanLoai = Helper.GetCategoryValue(result.PhanLoai);
                    return result;

                }
            }
            catch (Exception e)
            {
                return null;
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
                    sb.AppendLine("Tên,Loại,Hiệu,Đời,Hãng,Mô tả, Tình trạng, Phân loại");
                    foreach (var p in products)
                    {
                        sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", p.Ten, p.Loai, p.Hieu, p.Doi,
                            p.Hang, p.MoTa, p.TinhTrang, p.PhanLoai));
                    }

                    sw.Write(sb.ToString());
                    return true;
                }
            }
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
                    var v = (from p in dbContext.SanPhams
                             join d in dbContext.ThongTinSanPhams on p.ID equals d.ID
                             where p.ID.Equals(vehicle.ID)
                             select new ProductDto()
                             {
                                 ID = p.ID,
                                 Ten = p.Ten,
                                 Hieu = d.Hieu,
                                 Doi = d.Doi,
                                 Hang = d.Hang,
                                 MoTa = d.MoTa,
                                 TinhTrang = d.TinhTrang,
                                 PhanLoai = d.PhanLoai,
                                 Image1 = d.Image1,
                                 Image2 = d.Image2,
                                 Image3 = d.Image3,
                                 Image4 = d.Image4,
                                 Image5 = d.Image5
                             }).FirstOrDefault();

                    // edit
                    v.Ten = vehicle.Ten;
                    v.Hieu = vehicle.Hieu;
                    v.Doi = vehicle.Doi;
                    v.Hang = vehicle.Hang;
                    v.MoTa = vehicle.MoTa;
                    v.TinhTrang = vehicle.TinhTrang;
                    v.PhanLoai = vehicle.PhanLoai;
                    v.Image1 = vehicle.Image1;
                    v.Image2 = vehicle.Image2;
                    v.Image3 = vehicle.Image3;
                    v.Image4 = vehicle.Image4;
                    v.Image5 = vehicle.Image5;

                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
