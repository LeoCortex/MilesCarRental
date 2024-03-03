using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository;

public interface ICityRepository
{
    Task<IEnumerable<CityDTO>> GetAll();
    Task<CityDTO> GetById(int id);
    Task Add(CityDTO entity);
    Task<CityDTO> Update(CityDTO entity);
    Task<CityDTO> Delete(CityDTO entity);
}
