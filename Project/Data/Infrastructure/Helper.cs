using System.Collections.Generic;
using System.Linq;
using Data.Dtos;
using Data.Model;

namespace Data.Infrastructure
{
    public class Helper
    {
        public Helper()
        {
        }

        public static List<MasterDataDto> GetMasterData(string key1, string key2 = "", string key3 = "")
        {
            using (var dbContext = new XeNangEntities())
            {
                var result = (from m in dbContext.MasterDatas
                              where m.Keys.Equals(key1) || m.Keys.Equals(key2) || m.Keys.Equals(key3)
                              select new MasterDataDto()
                              {
                                  Name = m.Name,
                                  Value = m.Value,
                                  Key = m.Keys
                              }).ToList<MasterDataDto>();
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
