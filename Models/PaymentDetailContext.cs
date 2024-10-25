using Microsoft.EntityFrameworkCore;

namespace PaymentApi.Models
{
    public class PaymentDetailContext :DbContext
    {
        public PaymentDetailContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<PaymentDetails > PaymentDetails { get; set; }

    }
}
