using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomersApp.Models
{
    [Table("customersDetails")]
    public class CustomerDetail
    {
        [Key]
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }

        public string customerAddress { get; set; }

        public PurchaseData Purchases { get; set; }


    }
}
