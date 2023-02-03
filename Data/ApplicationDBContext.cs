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

    }
}
