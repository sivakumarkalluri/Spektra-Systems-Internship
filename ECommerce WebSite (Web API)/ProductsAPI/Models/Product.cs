using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public string ProductCategory { get; set; }

        public string ProductSubCategory { get; set; }

        public string gender { get; set; }
    }
}
