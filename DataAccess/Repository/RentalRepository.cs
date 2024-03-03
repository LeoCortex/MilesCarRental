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
    public class RentalRepository : IRentalRepository
    {
        protected readonly DataContext _context;
        private readonly IMapper _mapper;

        public RentalRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task Add(RentalDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<RentalDTO> Delete(RentalDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RentalDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<RentalDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RentalDTO> Update(RentalDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
