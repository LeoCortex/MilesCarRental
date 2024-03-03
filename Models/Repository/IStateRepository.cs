using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    public interface IStateRepository
    {
        Task<IEnumerable<StateDTO>> GetAll();
        Task<StateDTO> GetById(int id);
        Task Add(StateDTO entity);
        Task<StateDTO> Update(StateDTO entity);
        Task<StateDTO> Delete(StateDTO entity);
    }
}
