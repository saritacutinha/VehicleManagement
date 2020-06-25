using System.Threading.Tasks;
using VehicleManagement.Core;

namespace VehicleManagement.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VehicleManagementDbContext context;

        public  UnitOfWork(VehicleManagementDbContext context)
        {
            this.context = context;
        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
