using Microsoft.EntityFrameworkCore;
using VehicleAPI.Models;

namespace VehicleAPI.Contexts
{
    public class VehicleContext:DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options) : base(options) { 
        
         this.Database.EnsureCreated();
        }

        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
