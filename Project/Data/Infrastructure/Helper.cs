using System.Collections.Generic;
using System.Linq;
using Data.Dtos;
using Data.Model;
using System.Windows.Forms;

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

        #region REF
        public static void loadData_cbbPhanLoai(ComboBox cbb)
        {
            List<string> itemList = new List<string>();
            XeNangEntities conText = new XeNangEntities();
            var query = from a in conText.MasterDatas where a.Keys.Equals("Type") select a.Value;
            itemList = query.ToList();
            cbb.DataSource = itemList;
        }


        public static void loadData_cbbTinhTrang(ComboBox cbb)
        {
            List<string> itemList = new List<string>();
            XeNangEntities conText = new XeNangEntities();
            var query = from a in conText.MasterDatas where a.Keys.Equals("Status") select a.Value;
            itemList = query.ToList();
            cbb.DataSource = itemList;
        }

        public static void autoCompleteTenSanPham(TextBox tb, string Loai)
        {
            AutoCompleteStringCollection itemList = new AutoCompleteStringCollection();
            XeNangEntities conText = new XeNangEntities();
            var query = (from a in conText.SanPhams
                         where (a.Loai.Equals(Loai))
                         select a.Ten);
            itemList.AddRange(query.ToArray());
            tb.AutoCompleteCustomSource = itemList;
        }

        public static void autoCompleteTenSanPham(TextBox tb)
        {
            AutoCompleteStringCollection itemList = new AutoCompleteStringCollection();
            XeNangEntities conText = new XeNangEntities();
            var query = (from a in conText.SanPhams
                         select a.Ten);
            itemList.AddRange(query.ToArray());
            tb.AutoCompleteCustomSource = itemList;
        }

        public static string refName(ref string Name)
        {
            XeNangEntities conText = new XeNangEntities();
            var query = from a in conText.MasterDatas where a.Name.Equals("Name") select a.Value;
            Name = query.FirstOrDefault();
            return Name;
        }

        public static string refAddress(ref string Address)
        {
            XeNangEntities conText = new XeNangEntities();
            var query = from a in conText.MasterDatas where a.Name.Equals("Address") select a.Value;
            Address = query.FirstOrDefault();
            return Address;
        }

        public static string refTitle(ref string Title)
        {
            XeNangEntities conText = new XeNangEntities();
            var query = from a in conText.MasterDatas where a.Name.Equals("Title") select a.Value;
            Title = query.FirstOrDefault();
            return Title;
        }

        public static string refPhanLoai(string PhanLoai)
        {
            XeNangEntities conText = new XeNangEntities();
            var queryPL = (from m in conText.MasterDatas where m.Value.Equals(PhanLoai) select m.Name).FirstOrDefault();
            string PL = queryPL;
            return PL;
        }

        public static string refTinhTrang(string TinhTrang)
        {
            XeNangEntities conText = new XeNangEntities();
            var queryTT = (from m in conText.MasterDatas where m.Value.Equals(TinhTrang) select m.Name).FirstOrDefault();
            string TT = queryTT;
            return TT;
        }

        public static int refID(string TenSanPham)
        {
            XeNangEntities conText = new XeNangEntities();
            var queryID = (from p in conText.SanPhams where p.Ten.ToUpper().Equals(TenSanPham.ToUpper()) select p.ID).First();
            int ID = queryID;
            return ID;
        }

        public static string checkLoai(string type)
        {
            return type.Equals("Xe nâng") ? "01" : "02";
        }

        public static string checkStatus(string status)
        {
            return status.Equals("01") ? "Đã duyệt" : "Đang chờ";
        }
        #endregion

    }
}
