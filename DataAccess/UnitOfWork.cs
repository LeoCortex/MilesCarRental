using AutoMapper;
using DataAccess.Context;
using DataAccess.Model;
using DataAccess.Repository;
using Models;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        private AreaRepository _areaRepository;
        private CityRepository _cityRepository;
        private CustomerRepository _customerRepository;
        private LocationRepository _locationRepository;
        private RentalRepository _rentalRepository;
        private StateRepository _stateRepository;
        private VehicleLocationRepository _vehicleLocationRepository;
        private VehicleRepository _vehicleRepository;

        public UnitOfWork(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public ICustomerRepository Customer => _customerRepository ??= new CustomerRepository(_context, _mapper);
        public ILocationRepository Location => _locationRepository ??= new LocationRepository(_context, _mapper);
        public IRentalRepository Rental => _rentalRepository ??= new RentalRepository(_context, _mapper);
        public IVehicleLocationRepository VehicleLocation => _vehicleLocationRepository ??= new VehicleLocationRepository(_context, _mapper);
        public IVehicleRepository Vehicle => _vehicleRepository ??= new VehicleRepository(_context, _mapper);
        public IAreaRepository Area => _areaRepository ??= new AreaRepository(_context, _mapper);
        public ICityRepository City => _cityRepository ??= new CityRepository(_context, _mapper);
        public IStateRepository State => _stateRepository ??= new StateRepository(_context, _mapper);
        
        
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
