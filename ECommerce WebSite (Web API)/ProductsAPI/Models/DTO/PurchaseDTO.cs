using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.Models.DTO
{
    public class PurchaseDTO
    {
        [Key]
        public int id { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }

        public string image { get; set; }

        public string name { get; set; }
    }
}
