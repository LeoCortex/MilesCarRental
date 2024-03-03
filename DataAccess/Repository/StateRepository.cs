using Models.Repository.Domain.DTO;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Context;

namespace DataAccess.Repository
{
    public class StateRepository : IStateRepository
    {
        protected readonly DataContext _context;
        private readonly IMapper _mapper;

        public StateRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task Add(StateDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<StateDTO> Delete(StateDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StateDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<StateDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StateDTO> Update(StateDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
