using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFirstApp.TPT
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    //[Table("Employees")]
    public class Employee : Person
    {
        public decimal Salary { get; set; }
    }

    //[Table("Vendors")]
    public class Vendor : Person
    {
        public decimal HourlyRate { get; set; }
    }
}