using CodeFirstFirstApp.TPT;
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

        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DonatorMap());

            modelBuilder.Entity<Employee>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Employees");
            });

            modelBuilder.Entity<Vendor>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Vendor");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}