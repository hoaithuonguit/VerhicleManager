using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using Data.Dtos;
using Data.Infrastructure;
using Data.Model;

namespace Data.Repositories
{
    public class SellRepo : ISellRepo
    {
        public SellRepo()
        {
        }

        public string SellProduct(ProductDto product, int count, DateTime dateCreate)
        {
            try
            {
                using (var dbContext = new XeNangEntities())
                {
                    var productInStock = (dbContext.Khoes.First(p => p.ID == product.ID));
                    if (productInStock.SoLuong < count)
                        return Constant.MESSAGE_ERROR;

                    dbContext.BanHangs.Add(new BanHang()
                    {
                        ID_Product = product.ID,
                        NgayBan = dateCreate,
                        SoLuong = count,
                        ID = (from s in dbContext.BanHangs select s.ID).Count() + 1
                    });

                    productInStock.NgayUpdated = dateCreate;
                    productInStock.SoLuong -= count;
                    dbContext.SaveChanges();
                    return Constant.MESSAGE_SUCCESS;
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

        public List<OrderDetailDto> GetAllOrdersAreWaiting()
        {
            using (var dbContext = new XeNangEntities())
            {
                var result = (from o in dbContext.DatHangs
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


                if (result.Count > 0)
                    return result;

                return new List<OrderDetailDto>();
            }
        }
    }
}