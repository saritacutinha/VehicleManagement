using System.Threading.Tasks;

namespace VehicleManagement.Core
{
    public interface IUnitOfWork
    {
          Task CompleteAsync();
    }
}