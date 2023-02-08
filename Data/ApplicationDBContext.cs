using CallCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace CallCenter.Data
{
    public partial class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {

        }


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<ClientApplication> ClientApplication { get; set; }


    }
}
