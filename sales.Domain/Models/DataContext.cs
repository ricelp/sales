namespace sales.Domain.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base ("trasamConnectionString")
        {


        }

        public System.Data.Entity.DbSet<sales.Common.Models.Product> Products { get; set; }
    }
}
