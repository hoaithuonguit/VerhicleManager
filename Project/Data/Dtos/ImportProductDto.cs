using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class ImportProductDto
    {
        public int ID { get; set; }
        public DateTime DateCreate { get; set; }
        public int ID_Product { get; set; }
        public string ProductName { get; set; }
        public int Quantities { get; set; }
        public string Status { get; set; }
        public string Label { get; set; }
        public string Classification { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
