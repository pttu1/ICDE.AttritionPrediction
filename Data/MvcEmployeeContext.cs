using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ICDE.CompareProducts.Models;

namespace ICDE.CompareProducts.Data
{
    public class MvcEmployeeContext : DbContext
    {
        public MvcEmployeeContext (DbContextOptions<MvcEmployeeContext> options)
            : base(options)
            {
            }
            public DbSet<Employee> Employee { get; set; }
            public DbSet<RegModel> RegModel { get; set; }
    }
}
