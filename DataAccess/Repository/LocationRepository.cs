using AutoMapper;
using DataAccess.Context;
using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Models.Repository;
using Models.Repository.Domain;
using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class LocationRepository : ILocationRepository
    {
        protected readonly DataContext _context;
        private readonly IMapper _mapper;

        public LocationRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task Add(LocationDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<LocationDTO> Delete(LocationDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LocationDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<LocationDTO>> GetByArea(int idArea)
        {
            try
            {
                var currentUser = _context.Locations.Where(l => l.IdArea == idArea);
                if (currentUser == null)
                {
                    return Task.FromResult(_mapper.Map<List<LocationDTO>>(currentUser));
                }
                else
                {
                    throw new Exception($"No se encontraron Localizaciones para el area");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el usuario: {ex.Message}");
                throw;
            }
        }

        public Task<List<LocationDTO>> GetByCity(int idCity)
        {
            try
            {
                var currentUser = _context.Locations.Where(l => l.IdCity == idCity);
                if (currentUser == null)
                {
                    return Task.FromResult(_mapper.Map<List<LocationDTO>>(currentUser));
                }
                else
                {
                    throw new Exception($"No se encontraron Localizaciones para el area");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el usuario: {ex.Message}");
                throw;
            }
        }

        public Task<LocationDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LocationDTO>> GetByVehicle(int idVehicle)
        {
            try
            {
                var locations = from v in _context.Vehicles
                                join vl in _context.VehicleLocations on v.Id equals vl.IdVehicle
                                join l in _context.Locations on vl.IdLocation equals l.Id
                                where v.Id == idVehicle
                                select l;


                if (locations != null)
                {
                    return Task.FromResult(_mapper.Map<List<LocationDTO>>(locations));
                }
                else
                {
                    throw new Exception($"No se encontraron Localizaciones para el area");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el usuario: {ex.Message}");
                throw;
            }
        }

        public Task<LocationDTO> Update(LocationDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
