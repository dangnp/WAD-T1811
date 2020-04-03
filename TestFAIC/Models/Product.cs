using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestFAIC.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public Category CategoryID { get; set; }
        [Display(Name = "Tên sản phẩm")]

        public string ProductName { get; set; }
        [Display(Name = "Đơn vị định lượng")]

        public int QuantityPerUnit { get; set; }
        [Display(Name = "Giá")]

        public int UnitPrice { get; set; }
        [Display(Name = "số lượng trong kho")]

        public int UnitInStock { get; set; }
        [Display(Name = "Số lượng được đặt hàng")]
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        [Display(Name = "Giảm giá")]
        public int Discontinued { get; set; }

    }
}