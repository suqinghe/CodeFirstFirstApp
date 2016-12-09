using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstFirstApp
{
    public class DonatorType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Donator> Donaotrs { get; set; }
    }

    public class DonatorTypeMap : EntityTypeConfiguration<DonatorType>
    {
        public DonatorTypeMap()
        {
            HasMany(a => a.Donaotrs)
                .WithOptional(a => a.DonatorType)
                .HasForeignKey(a => a.DonatorTypeId)
                .WillCascadeOnDelete(false);
        }
    }
}