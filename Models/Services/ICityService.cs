using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface ICityService
    {
        Task<IEnumerable<CityDTO>> GetAll();
        Task<CityDTO> GetById(int id);
    }
}
