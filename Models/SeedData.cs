using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace ComicsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ComicsStoreDbContext context =
            app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService <ComicsStoreDbContext> ();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Comics.Any())
            {
                context.Comics.AddRange(
               
                ); context.SaveChanges();
            }
        }
    }
}