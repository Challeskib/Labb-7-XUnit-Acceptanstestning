using Labb_7___XUnit___Acceptanstestning.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___XUnit___Acceptanstestning.Services
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public virtual DbSet<CalculatorLog> CalculatorLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = LAPTOP-QU0DA4M8;database = CalculatorLabb7;Trusted_Connection = True; TrustServerCertificate = true;");
        }

    }
}
