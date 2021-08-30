using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Customer_Web_API_Demo.Models;

namespace Customer_Web_API_Demo.Data
{
    public class Customer_Web_API_DemoContext : DbContext
    {
        public Customer_Web_API_DemoContext (DbContextOptions<Customer_Web_API_DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Customer_Web_API_Demo.Models.Customer> Customer { get; set; }
    }
}
