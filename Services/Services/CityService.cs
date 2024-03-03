using Models.Repository.Domain.DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Services;

namespace Services.Services
{
    public class CityService : ICityService 
    {
        private readonly IUnitOfWork _unitOfWork;

        public CityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public  async Task<IEnumerable<CityDTO>> GetAll()
        {
            try
            {
                var locations = _unitOfWork.City.GetAll();
                List<CityDTO> cities = (List<CityDTO>)await locations;
                return cities ?? throw new ApplicationException("No Cities found");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public async Task<CityDTO> GetById(int id)
        {
            try
            {
                var locations = _unitOfWork.City.GetById(id);
                CityDTO cities = await locations;
                return cities ?? throw new ApplicationException("No City found");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
