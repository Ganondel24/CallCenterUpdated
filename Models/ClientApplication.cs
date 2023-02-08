using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CallCenter.Models
{
    public class ClientApplication
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


    }
}
