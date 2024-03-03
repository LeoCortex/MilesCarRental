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
    public class VehicleLocationRepository : Repository<VehicleLocationDTO>, IVehicleLocationRepository
    {
        private readonly IMapper _mapper;

        public VehicleLocationRepository(DataContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }
    }
}
