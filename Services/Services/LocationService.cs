using Models;
using Models.Repository.Domain.DTO;
using Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class LocationService : ILocationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LocationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<LocationDTO>> GetByArea(int idArea)
        {
            try
            {
                var locations = _unitOfWork.Location.GetByArea(idArea);
                return locations ?? throw new ApplicationException("No locations found for the given area.");
            }
            catch(Exception ex) 
            {
                throw new ApplicationException(ex.Message);
            }

        }

        public Task<List<LocationDTO>> GetByCity(int idCity)
        {
            try
            {
                var locations = _unitOfWork.Location.GetByCity(idCity);
                return locations ?? throw new ApplicationException("No locations found for the given City.");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public Task<List<LocationDTO>> GetByVehicle(int idVehicle)
        {
            try
            {
                var locations = _unitOfWork.Location.GetByVehicle(idVehicle);
                return locations ?? throw new ApplicationException("No locations found for the given Vehicle.");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
