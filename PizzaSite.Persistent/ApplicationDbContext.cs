using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSite.Persistent
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=PizzaSiteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Price> Prices { get; set; }
    }

    public class Order
    {
        public System.Guid Id { get; set; }
        public PizzaSite.DTO.Enums.Size Size { get; set; }
        public PizzaSite.DTO.Enums.Crust Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public bool Completed { get; set; }
        public PizzaSite.DTO.Enums.PaymentType PaymentType { get; set; }
    }

    public class Price
    {
        public int Id { get; set; }
        public decimal SmallSizeCost { get; set; }
        public decimal MediumSizeCost { get; set; }
        public decimal LargeSizeCost { get; set; }
        public decimal ThinCrustCost { get; set; }
        public decimal RegularCrustCost { get; set; }
        public decimal ThickCrustCost { get; set; }
        public decimal SausageCost { get; set; }
        public decimal PepperoniCost { get; set; }
        public decimal OnionsCost { get; set; }
        public decimal GreenPepperCost { get; set; }
    }
}
