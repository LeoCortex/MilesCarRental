using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    public interface ILocationRepository
    {
        Task<IEnumerable<LocationDTO>> GetAll();
        Task<LocationDTO> GetById(int id);
        Task Add(LocationDTO entity);
        Task<LocationDTO> Update(LocationDTO entity);
        Task<LocationDTO> Delete(LocationDTO entity);
        Task<List<LocationDTO>> GetByArea(int idArea);
        Task<List<LocationDTO>> GetByCity(int idCity);
        Task<List<LocationDTO>> GetByVehicle(int idVehicle);


    }
}
