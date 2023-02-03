using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CallCenter.Models
{
    [Index(nameof(BenefitNumber), IsUnique = true)]
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public string CustomerAFM { get; set; }

        public string BenefitNumber { get; set; }

        public string PhoneNumber { get; set; }
        public string CustmerAddress { get; set; }

    }
}
