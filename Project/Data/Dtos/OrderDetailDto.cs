using System;

namespace Data.Dtos
{
    public class OrderDetailDto
    {
        public int ID { get; set; }
        public DateTime DateCreate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddr { get; set; }
        public string CustomerPhoneNo { get; set; }
        public string CustomerEmail { get; set; }
        public string ProductName { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public int Quantities { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
