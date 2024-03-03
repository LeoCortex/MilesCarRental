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
    internal class RentalServices : IRentalService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RentalServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task Add(RentalDTO rental)
        {
            try
            {
                var locations = _unitOfWork.Rental.Add(rental);
                return locations ?? throw new ApplicationException("Error creating Rental");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }

        public Task<IEnumerable<RentalDTO>> GetAll()
        {
            try
            {
                var locations = _unitOfWork.Rental.GetAll();
                return locations ?? throw new ApplicationException("No Rental found");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public Task<RentalDTO> GetById(int id)
        {
            try
            {
                var locations = _unitOfWork.Rental.GetById(id);
                return locations ?? throw new ApplicationException("No Rental found");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
