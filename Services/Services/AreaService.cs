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
    public class AreaService : IAreaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AreaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<IEnumerable<AreaDTO>> GetAll()
        {
            try
            {
                var locations = _unitOfWork.Area.GetAll();
                return locations ?? throw new ApplicationException("No Areas found.");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public Task<AreaDTO> GetById(int id)
        {
            try
            {
                var locations = _unitOfWork.Area.GetById(id);
                return locations ?? throw new ApplicationException("No Area found.");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
