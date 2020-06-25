using System.Threading.Tasks;

namespace VehicleManagement.Persistence
{
    public interface IUnitOfWork
    {
          Task CompleteAsync();
    }
}