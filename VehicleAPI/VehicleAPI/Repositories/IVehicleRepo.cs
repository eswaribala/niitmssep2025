using VehicleAPI.Models;

namespace VehicleAPI.Repositories
{
    public interface IVehicleRepo
    {
        Task<Vehicle> AddVehicle(Vehicle vehicle);
        Task<bool> RemoveVehicle(Vehicle vehicle);
        Task<Vehicle> GetVehicle(string vehicleId);
        Task<IEnumerable<Vehicle>> GetVehicles();
        Task<Vehicle> UpdateVehicle(string RegNo, string color);         



    }
}
