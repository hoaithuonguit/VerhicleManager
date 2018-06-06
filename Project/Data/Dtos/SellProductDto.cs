using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class SellProductDto
    {
        public int ID { get; set; }
        public int ID_Product { get; set; }
        public string Category { get; set; }
        public string ProductName { get; set; }
        public int Quantities { get; set; }
        public DateTime DateOfSale { get; set; }
    }
}
