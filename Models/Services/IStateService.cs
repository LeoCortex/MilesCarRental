using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    internal interface IStateService
    {
        Task<IEnumerable<StateDTO>> GetAll();
        Task<StateDTO> GetById(int id);
    }
}
