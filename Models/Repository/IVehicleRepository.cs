using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<VehicleDTO>> GetAll();
        Task<VehicleDTO> GetById(int id);
        Task Add(VehicleDTO entity);
        Task<VehicleDTO> Update(VehicleDTO entity);
        Task<VehicleDTO> Delete(VehicleDTO entity);
        Task<List<VehicleDTO>> GetByArea(int idArea);
        Task<List<VehicleDTO>> GetByCity(int idVehicle);
        Task<List<VehicleDTO>> GetByLocation(int idLocation);
    }
}
