using VehicleAPI.Models;

namespace VehicleAPI.Repositories
{
    public class VehicleRepo : IVehicleRepo
    {
        public Task<Vehicle> AddVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> GetVehicle(string vehicleId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehicle>> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> UpdateVehicle(string RegNo, string color)
        {
            throw new NotImplementedException();
        }
    }
}
