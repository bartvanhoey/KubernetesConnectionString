using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TodoItemsAPI.DAL
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                try
                {
                    using var dbContext = scope.ServiceProvider.GetRequiredService<TodoItemDbContext>();
                    dbContext.Database.EnsureDeleted(); // DO NOT USE IN PRODUCTION
                    dbContext.Database.Migrate();
                }
                catch (Exception ex)
                {
                    //Log errors or do anything you think it's needed
                    Debug.WriteLine(ex.Message);
                    throw;
                }
            }
            return webHost;
        }
    }
}