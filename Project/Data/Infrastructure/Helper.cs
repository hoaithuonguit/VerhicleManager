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
        public Helper() { }

        public List<T> GetMasterData<T>(string key1, string key2 = "", string key3 = "") where T : MasterDataDto, new()
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
    }
}
