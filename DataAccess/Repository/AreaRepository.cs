using AutoMapper;
using DataAccess.Context;
using Models.Repository.Domain.DTO;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class AreaRepository : IAreaRepository
    {
        protected readonly DataContext _context;
        private readonly IMapper _mapper;

        public AreaRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<IEnumerable<AreaDTO>> GetAll()
        {
            try
            {
                var result = _mapper.Map<List<AreaDTO>>(_context.Set<City>());
                return await Task.FromResult(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update entity", ex);
            }
        }

        public Task<AreaDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Add(AreaDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<AreaDTO> Delete(AreaDTO entity)
        {
            throw new NotImplementedException();
        }


        public Task<AreaDTO> Update(AreaDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
