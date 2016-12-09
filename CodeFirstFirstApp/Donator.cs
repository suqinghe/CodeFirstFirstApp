using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFirstApp
{
    public class Donator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonateDate { get; set; }
        public virtual ICollection<PayWay> PayWays { get; set; }

        public int? DonatorTypeId { get; set; }
        public virtual DonatorType DonatorType { get; set; }

        public Donator()
        {
            PayWays = new HashSet<PayWay>();
        }
    }

    public class DonatorMap : EntityTypeConfiguration<Donator>
    {
        public DonatorMap()
        {
            ToTable("Donators");
            Property(m => m.Name)
                .IsRequired(); //将Name设置为必须的

            HasMany(d => d.PayWays)
                .WithRequired()
                .HasForeignKey(p => p.DonatorId);
        }
    }
}