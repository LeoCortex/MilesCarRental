using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IUnitOfWork : IDisposable
    {
        IAreaRepository Area { get; }
        ICityRepository City { get; }
        ICustomerRepository Customer { get; }
        ILocationRepository Location { get; }
        IRentalRepository Rental { get; }
        IStateRepository State { get; }
        IVehicleLocationRepository VehicleLocation { get; }
        IVehicleRepository Vehicle { get; }
        Task<int> CommitAsync();
    }
}
