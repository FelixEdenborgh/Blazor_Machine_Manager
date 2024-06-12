using Blazor_Machine_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Machine_Manager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Machine> Machines { get; set; }

        // Test data
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Machines.Any())
            {
                return;
            }

            var machines = new[]
            {
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 1",
                    IsOnline = true,
                    LastUpdated = DateTime.Now
                },
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 2",
                    IsOnline = false,
                    LastUpdated = DateTime.Now
                },
                new Machine
                {
                    Id = Guid.NewGuid(),
                    Name = "Machine 3",
                    IsOnline = true,
                    LastUpdated = DateTime.Now
                }
            };

            context.Machines.AddRange(machines);
            context.SaveChanges();
        }
    }
}
