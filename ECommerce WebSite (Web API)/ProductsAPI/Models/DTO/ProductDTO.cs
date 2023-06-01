using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAPI.Models.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Description { get; set; }
        
        public string ImagePath { get; set; }

        public string ProductCategory { get; set; }

        public string ProductSubCategory { get; set; }

        public string gender { get; set; }
    }
}
