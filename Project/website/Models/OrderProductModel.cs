using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace website.Models
{
    public class OrderProductModel
    {
        [Display(Name = "Tên")]
        [Required(ErrorMessage ="{0} là bắt buộc")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} là bắt buộc")]
        public string Email { get; set; }
        [Display(Name = "Tên")]
        [Required(ErrorMessage = "{0} là bắt buộc")]
        public string ProductName { get; set; }
        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "{0} là bắt buộc")]
        
        public int Count { get; set; }
        [Display(Name = "Ngày")]
        [Required(ErrorMessage = "{0} là bắt buộc")]
        public DateTime DateRecieved { get; set; }
        public string Description { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "{0} là bắt buộc")]
        public string Address { get; set; }
        [Display(Name = "Sđt")]
        [Required(ErrorMessage = "{0} là bắt buộc")]
        public string Sdt { get; set; }
    }
}