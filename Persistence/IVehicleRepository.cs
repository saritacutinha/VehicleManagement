using System.Threading.Tasks;
using VehicleManagement.Migrations;
using VehicleManagement.Models;


namespace VehicleManagement.Persistence
{
    public interface IVehicleRepository<TVehicle> where TVehicle : Models.Vehicle
    {
        Task<TVehicle> GetVehicle(int id);
    }
}   