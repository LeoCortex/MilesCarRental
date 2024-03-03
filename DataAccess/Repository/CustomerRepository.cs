using AutoMapper;
using DataAccess.Context;
using Models.Repository;
using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IMapper _mapper;

        public CustomerRepository(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task Add(CustomerDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDTO> Delete(CustomerDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDTO> Update(CustomerDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
