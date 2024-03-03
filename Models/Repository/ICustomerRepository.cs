using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerDTO>> GetAll();
        Task<CustomerDTO> GetById(int id);
        Task Add(CustomerDTO entity);
        Task<CustomerDTO> Update(CustomerDTO entity);
        Task<CustomerDTO> Delete(CustomerDTO entity);
    }
}
