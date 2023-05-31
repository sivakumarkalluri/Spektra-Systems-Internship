using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomersApp.Models
{
    [Table("purchaseData")]
    public class PurchaseData
    {

        [Key, ForeignKey("Customer")]
        public int customerID {  get; set; }
        public int purchaseId { get; set; }

        public decimal TotalPrice { get; set; }

        public CustomerDetail Customer { get; set; }


    }
}
