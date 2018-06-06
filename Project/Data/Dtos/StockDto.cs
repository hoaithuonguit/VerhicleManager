using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class StockDto
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string ProductName { get; set; }
        public int Inventories { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
