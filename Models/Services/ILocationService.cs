using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Models.Services
{
    public interface ILocationService
    {
        Task<List<LocationDTO>> GetByCity(int idCity);
        Task<List<LocationDTO>> GetByArea(int idArea);
        Task<List<LocationDTO>> GetByVehicle(int idVehicle);

    }
}
