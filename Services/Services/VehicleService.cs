using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository.Domain.DTO;
using Models.Services;

namespace Services.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehicleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<VehicleDTO>> GetByArea(int idArea)
        {
            try
            {
                var Vehicles = _unitOfWork.Vehicle.GetByArea(idArea);
                return Vehicles ?? throw new ApplicationException("No Vehicle found for the given area.");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public Task<List<VehicleDTO>> GetByCity(int idCity)
        {
            try
            {
                var Vehicles = _unitOfWork.Vehicle.GetByCity(idCity);
                return Vehicles ?? throw new ApplicationException("No Vehicle found for the given City.");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public Task<List<VehicleDTO>> GetByLocation(int idLocation)
        {
            try
            {
                var Vehicles = _unitOfWork.Vehicle.GetByLocation(idLocation);
                return Vehicles ?? throw new ApplicationException("No Vehicle found for the given Location.");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
