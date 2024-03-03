using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    public interface IRentalRepository
    {
        Task<IEnumerable<RentalDTO>> GetAll();
        Task<RentalDTO> GetById(int id);
        Task Add(RentalDTO entity);
        Task<RentalDTO> Update(RentalDTO entity);
        Task<RentalDTO> Delete(RentalDTO entity);
    }
}
