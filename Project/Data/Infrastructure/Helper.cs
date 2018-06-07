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

        // get "Value" field  in MasterDate with "Name" as parameter
        public static string GetValueFromNameInMaster(string name)
        {
            using (var dbContext = new XeNangEntities())
            {
                string result = (from m in dbContext.MasterDatas where m.Name.Equals(name) select m.Value)
                    .FirstOrDefault();
                return result;
            }
        }

        // get "Name" field in MasterData with "Value" as parameter
        public static string GetNameFromValueInMaster(string value)
        {
            using (var dbContext = new XeNangEntities())
            {
                string result = (from m in dbContext.MasterDatas where m.Value.Equals(value) select m.Name)
                    .FirstOrDefault();
                return result;
            }
        }

        public static string GetTypeName(string type)
        {
            return type.Equals("01") ? "Xe nâng" : "Phụ tùng";
        }

        // return ID of product or -1 if product is not available
        public static int GetIDFromName(string productName)
        {
            using (var dbContext = new XeNangEntities())
            {
                int result =
                    (from p in dbContext.SanPhams where p.Ten.ToUpper().Equals(productName.ToUpper()) select p.ID).DefaultIfEmpty(-1).FirstOrDefault();
                return result;
            }
        }

        public static string GetTypeID(string type)
        {
            return type.Equals("Xe nâng") ? "01" : "02";
        }

    }
}
