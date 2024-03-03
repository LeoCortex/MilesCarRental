using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IAreaService
    {
        Task<IEnumerable<AreaDTO>> GetAll();
        Task<AreaDTO> GetById(int id);
    }
}
