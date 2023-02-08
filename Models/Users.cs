using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CallCenter.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }

    }
}
