using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;

namespace Data.Infrastructure
{
    public class Helper
    {
        public Helper()
        {
        }

        public static List<T> GetMasterData<T>(string key1, string key2 = "", string key3 = "") where T : MasterDataDto, new()
        {
            using (var dbContext = new XeNangEntities())
            {
                var result = (from c in dbContext.MasterDatas
                              where c.Keys == key1 || c.Keys == key2 || c.Keys == key3
                              select new T()
                              {
                                  ID = c.ID,
                                  Name = c.Name,
                                  Value = c.Value
                              }).ToList<T>();
                return result;
            }
        }

        public static string GetStatusValue(string statusName)
        {
            using (var dbContext = new XeNangEntities())
            {
                string result = (from m in dbContext.MasterDatas where m.Name == statusName select m.Value)
                    .FirstOrDefault();
                return result;
            }
        }

        public static string GetCategoryValue(string categoryName)
        {
            using (var dbContext = new XeNangEntities())
            {
                string result = (from m in dbContext.MasterDatas where m.Name == categoryName select m.Value)
                    .FirstOrDefault();
                return result;
            }
        }

        public static string CheckType(string type)
        {
            return type.Equals("01") ? "Xe nâng" : "Phụ tùng";
        }

    }
}
