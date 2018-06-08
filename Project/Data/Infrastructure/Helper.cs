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

        // get all Value field in Master Data with "key" as parameter
        public static List<string> GetAllValueInMasterData(string key)
        {
            return (from t in GetMasterData(key) select t.Value).ToList<string>();
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

        // gets/sets store informtion
        public static string NameStore(ref string name)
        {
            using (var dbContext = new XeNangEntities())
            {
                var result = from n in dbContext.MasterDatas where n.Name.Equals("Name") select n.Value;
                name = result.FirstOrDefault();
                if (name != null)
                    return name;
                return "";
            }
        }

        public static string TitleStore(ref string title)
        {
            using (var dbContext = new XeNangEntities())
            {
                var result = from n in dbContext.MasterDatas where n.Name.Equals("Title") select n.Value;
                title = result.FirstOrDefault();
                if (title != null)
                    return title;
                return "";
            }
        }

        public static string AddressStore(ref string address)
        {
            using (var dbContext = new XeNangEntities())
            {
                var result = from n in dbContext.MasterDatas where n.Name.Equals("Address") select n.Value;
                address = result.FirstOrDefault();
                if (address != null)
                    return address;
                return "";
            }
        }

    }
}
