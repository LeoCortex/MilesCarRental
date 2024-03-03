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
    internal class VehicleRepository : IVehicleRepository
    {

        protected readonly DataContext _context;
        private readonly IMapper _mapper;

        public VehicleRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task Add(VehicleDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleDTO> Delete(VehicleDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VehicleDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<VehicleDTO>> GetByArea(int idArea)
        {
            try
            {
                var vehicles = from l in _context.Locations
                               join vl in _context.VehicleLocations on l.Id equals vl.IdLocation
                               join v in _context.Vehicles on vl.IdVehicle equals v.Id
                               where l.IdArea == idArea
                               select v;

                if (vehicles != null)
                {
                    return Task.FromResult(_mapper.Map<List<VehicleDTO>>(vehicles));
                }
                else
                {
                    throw new Exception($"No se encontraron Vehiculos para el area");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los vehiculos: {ex.Message}");
                throw;
            }
        }

        public Task<List<VehicleDTO>> GetByCity(int idCity)
        {
            try
            {
                var vehicles = from l in _context.Locations
                               join vl in _context.VehicleLocations on l.Id equals vl.IdLocation
                               join v in _context.Vehicles on vl.IdVehicle equals v.Id
                               where l.IdCity == idCity
                               select v;
                if (vehicles == null)
                {
                    return Task.FromResult(_mapper.Map<List<VehicleDTO>>(vehicles));
                }
                else
                {
                    throw new Exception($"No se encontraron Localizaciones para la ciudad");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el vehiculo: {ex.Message}");
                throw;
            }
        }

        public Task<VehicleDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VehicleDTO>> GetByLocation(int idLocation)
        {
            try
            {
                var Vehicles = from vl in _context.VehicleLocations 
                                join v in _context.Vehicles on vl.IdVehicle equals v.Id
                                where  vl.Id == idLocation
                               select v;

                if (Vehicles != null)
                {
                    return Task.FromResult(_mapper.Map<List<VehicleDTO>>(Vehicles));
                }
                else
                {
                    throw new Exception($"No se encontraron vehiculos para la localidad");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los vehiculos: {ex.Message}");
                throw;
            }
        }

        public Task<VehicleDTO> Update(VehicleDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
