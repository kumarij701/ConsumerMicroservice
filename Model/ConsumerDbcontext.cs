using Microsoft.EntityFrameworkCore;

namespace ConsumerMicroservice.Model
{
    public partial class ConsumerDbcontext : DbContext
    {

        public ConsumerDbcontext()
        {
        }
        public ConsumerDbcontext(DbContextOptions<ConsumerDbcontext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("Data Source = BYODHSQ5DX2\\MSSQLSERVERNEW; Initial Catalog = Policy; Integrated Security = True");
            }
        }

        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<BusinessMaster> BusinessMaster { get; set; }
        public virtual DbSet<Consumer> Consumer { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyMaster> PropertyMaster { get; set; }
    }
}
