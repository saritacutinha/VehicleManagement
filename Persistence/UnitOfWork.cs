using System.Threading.Tasks;

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
