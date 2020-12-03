using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace HRM.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Id = 1,
                        Name = "Tuan",
                        Category = "https://nld.mediacdn.vn/thumb_w/540/2020/5/29/doi-hoa-tim-8-15907313395592061395682.png",
                        Luong = 1000,
                        Age = 20
                    },
               new Product
               {
                   Id = 2,
                   Name = "Toan",
                   Category = "https://nld.mediacdn.vn/thumb_w/540/2020/5/29/doi-hoa-tim-8-15907313395592061395682.png",
                   Luong = 2000,
                   Age = 23
               },
               new Product
               {
                   Id = 3,
                   Name = "Binh",
                   Category = "https://nld.mediacdn.vn/thumb_w/540/2020/5/29/doi-hoa-tim-8-15907313395592061395682.png",
                   Luong = 2200,
                   Age = 25
               },
               new Product
               {
                   Id = 4,
                   Name = "Luong",
                   Category = "https://nld.mediacdn.vn/thumb_w/540/2020/5/29/doi-hoa-tim-8-15907313395592061395682.png",
                   Luong = 2500,
                   Age = 30
               },
               new Product
               {
                   Id = 5,
                   Name = "Chinh",
                   Category = "https://nld.mediacdn.vn/thumb_w/540/2020/5/29/doi-hoa-tim-8-15907313395592061395682.png",
                   Luong = 1500,
                   Age = 21
               }
                );
                context.SaveChanges();
           
            }
        }
    }
}
