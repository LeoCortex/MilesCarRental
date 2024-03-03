using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    public interface IAreaRepository
    {
        Task<IEnumerable<AreaDTO>> GetAll();
        Task<AreaDTO> GetById(int id);
        Task Add(AreaDTO entity);
        Task<AreaDTO> Update(AreaDTO entity);
        Task<AreaDTO> Delete(AreaDTO entity);
    }
}
