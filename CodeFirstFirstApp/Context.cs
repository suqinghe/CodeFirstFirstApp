using System.Data.Entity;

namespace CodeFirstFirstApp
{
    public class Context : DbContext
    {
        public Context()
            : base("name=CodeFirstFirstApp")
        {
        }

        public DbSet<Donator> Donators { get; set; }
        public DbSet<PayWay> PayWays { get; set; }
        public DbSet<DonatorType> DonatorTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DonatorMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}