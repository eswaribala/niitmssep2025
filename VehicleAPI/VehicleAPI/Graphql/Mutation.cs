using VehicleAPI.Contexts;
using VehicleAPI.DTO;
using VehicleAPI.Models;

namespace VehicleAPI.Graphql
{
    public class Mutation
    {

        public async Task<Vehicle> CreateVehicle([Service] VehicleContext db, VehicleDTO input)
        {
            var vehicle = new Vehicle
            {
                RegistrationId = input.RegistrationId,
                Maker = input.Maker,
                DOR = input.DOR,
                ChassisNo = input.ChassisNo,
                EngineNo = input.EngineNo,
                Color = input.Color,
                FuelType = input.FuelType
               
            };
            db.Vehicles.Add(vehicle);
            db.SaveChangesAsync();
            return vehicle;
        }

    }
}
