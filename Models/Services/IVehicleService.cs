using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IVehicleService
    {
        Task<List<VehicleDTO>> GetByCity(int idCity);
        Task<List<VehicleDTO>> GetByArea(int idArea);
        Task<List<VehicleDTO>> GetByLocation(int idLocation);
    }
}
