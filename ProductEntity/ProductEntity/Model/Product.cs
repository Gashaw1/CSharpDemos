using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEntity.ProductDBContext
{
    [Table("Product")]
   public class Product
    {
        public Product()
        {
        }
        [Required]
        [Key]
        public int UserID { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductQuantity { get; set; }       
    }
}
