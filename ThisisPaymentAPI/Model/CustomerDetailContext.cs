using Microsoft.EntityFrameworkCore;

namespace ThisisPaymentAPI.Model
{
    public class CustomerDetailContext : DbContext
    {
        public  CustomerDetailContext(DbContextOptions<CustomerDetailContext> options) : base(options)
    {

    }
    public DbSet<CustomerDetail> CustomerDetail { get; set; }
}
}

