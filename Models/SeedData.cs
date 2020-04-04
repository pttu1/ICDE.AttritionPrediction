using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ICDE.CompareProducts.Data;

namespace ICDE.CompareProducts.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcEmployeeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcEmployeeContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        Id = 1,
                        Age = 24,
                        BusinessTravel = "Rarely-Travel",
                        DistanceFromHome = 344
                    },

                    new Employee
                    {
                        Id = 2,
                        Age = 43,
                        BusinessTravel = "Regularly-Travel",
                        DistanceFromHome = 304
                    },

                    new Employee
                    {
                        Id = 3,
                        Age = 33,
                        BusinessTravel = "Rarely-Travel",
                        DistanceFromHome = 244
                    },

                    new Employee
                    {
                        Id = 2,
                        Age = 43,
                        BusinessTravel = "Regularly-Travel",
                        DistanceFromHome = 254
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
