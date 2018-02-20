using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcPrueba.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCarContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcCarContext>>()))
            {
                // Look for any movies.
                if (context.Make.Any())
                {
                    return;   // DB has been seeded
                }

                context.Make.AddRange(
                     new Make
                     {
                         Marca = "NISSAN",
                        
                     },

                     new Make
                     {
                          Marca = "TOYOTA",
                     },

                     new Make
                     {
                          Marca = "HYUNDAI",
                     }

                 
                );
                context.SaveChanges();
            }
        }
    }
}