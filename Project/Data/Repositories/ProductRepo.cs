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
        public ProductRepo() { }

        public bool AddProduct(ProductDto product)
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
                        Loai = product.Loai,
                        Ten = product.Ten,
                        ID = ID
                    });

                    dbContext.ThongTinSanPhams.Add(new ThongTinSanPham()
                    {
                        Hieu = product.Hieu,
                        Doi = product.Doi,
                        Hang = product.Hang,
                        MoTa = product.MoTa,
                        TinhTrang = product.TinhTrang,
                        PhanLoai = product.PhanLoai,
                        Image1 = product.Image1,
                        Image2 = product.Image2,
                        Image3 = product.Image3,
                        Image4 = product.Image4,
                        Image5 = product.Image5,
                        ID = ID
                    });

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

        public bool ImportProduct(ProductDto product, int count)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    dbContext.NhapHangs.Add(new NhapHang()
                    {
                        NgayNhapHang = DateTime.Today,
                        ID_Product = product.ID,
                        SoLuong = count,
                        TinhTrang = product.TinhTrang,
                        Hang = product.Hang,
                        PhanLoaiXe = product.PhanLoai,
                        MoTa = product.MoTa,
                        Loai = product.Loai,
                        ID = (from s in dbContext.NhapHangs select s.ID).Count()
                    });

                    var thisProductInStock = dbContext.Khoes.Where(p => p.ID == product.ID).DefaultIfEmpty(null).FirstOrDefault();
                    if (thisProductInStock == null)
                    {
                        dbContext.Khoes.Add(new Kho()
                        {
                            ID = product.ID,
                            NgayUpdated = DateTime.Now,
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

        public bool SellProduct(ProductDto product, int count)
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
                        NgayBan = DateTime.Now,
                        SoLuong = count,
                        ID = (from s in dbContext.BanHangs select s.ID).Count()
                    });
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

        public List<ProductDto> GetTopProduct(int range)
        {
            using (var dbContext = new XeNangEntities())
            {
                var date = DateTime.Now.AddDays(-7).Date;
                var result = ((from b in dbContext.BanHangs
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
                                   TinhTrang = (from m in dbContext.MasterDatas where m.Name == pg.Key.TinhTrang select m.Value).FirstOrDefault(),
                                   PhanLoai = (from m in dbContext.MasterDatas where m.Name == pg.Key.PhanLoai select m.Value).FirstOrDefault(),
                                   Image1 = pg.Key.Image1,
                                   Image2 = pg.Key.Image2,
                                   Image3 = pg.Key.Image3,
                                   Image4 = pg.Key.Image4,
                                   Image5 = pg.Key.Image5
                               }).Take(range)).ToList<ProductDto>();
                return result;
            }
        }

        public List<ProductDto> GetAll()
        {
            using (var dbContext = new XeNangEntities())
            {
                var result = (from p in dbContext.SanPhams
                              join d in dbContext.ThongTinSanPhams on p.ID equals d.ID
                              select new ProductDto()
                              {
                                  ID = p.ID,
                                  Ten = p.Ten,
                                  Loai = p.Loai,
                                  Hieu = d.Hieu,
                                  Hang = d.Hang,
                                  Doi = d.Doi,
                                  MoTa = d.MoTa,
                                  TinhTrang = (from m in dbContext.MasterDatas where m.Name == d.TinhTrang select m.Value)
                                      .FirstOrDefault(),
                                  PhanLoai = (from m in dbContext.MasterDatas where m.Name == d.PhanLoai select m.Value)
                                      .FirstOrDefault(),
                                  Image1 = d.Image1,
                                  Image2 = d.Image2,
                                  Image3 = d.Image3,
                                  Image4 = d.Image4,
                                  Image5 = d.Image5,
                              }).ToList<ProductDto>();

                return result;
            }
        }

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

        public ProductDto GetProduct(int id)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    var result = (from p in dbContext.SanPhams
                        join d in dbContext.ThongTinSanPhams on p.ID equals d.ID
                        where p.ID == id
                        select new ProductDto()
                        {
                            ID = id,
                            Ten = p.Ten,
                            Loai = p.Loai,
                            Doi = d.Doi,
                            Hang = d.Hang,
                            Hieu = d.Hieu,
                            TinhTrang = (from m in dbContext.MasterDatas where m.Name == d.TinhTrang select m.Value)
                                .FirstOrDefault(),
                            PhanLoai = (from m in dbContext.MasterDatas where m.Name == d.PhanLoai select m.Value)
                                .FirstOrDefault(),
                            Image1 = d.Image1,
                            Image2 = d.Image2,
                            Image3 = d.Image3,
                            Image4 = d.Image4,
                            Image5 = d.Image5,
                            MoTa = d.MoTa,
                        }).FirstOrDefault();
                    return result;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
