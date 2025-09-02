using Microsoft.EntityFrameworkCore;
using VehicleAPI.Contexts;
using VehicleAPI.Models;

namespace VehicleAPI.Graphql
{
    public class Queries
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [UsePaging]

        public IQueryable<Vehicle> GetVehicles([Service] VehicleContext context) =>
            context.Vehicles.AsNoTracking();
        [UseProjection]
        public Task<Vehicle> GetVehiclesById([Service] VehicleContext context, string id) =>
            context.Vehicles.AsNoTracking().FirstOrDefaultAsync(v =>v.RegistrationId == id);

    }
}
