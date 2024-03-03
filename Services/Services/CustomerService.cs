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
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<string> Add(CustomerDTO customer)
        {
            try
            {
                var locations = _unitOfWork.Customer.Add(customer);
                return locations != null ? Task.FromResult(locations.Id.ToString()) : throw new ApplicationException("Error creating Customer");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public Task<IEnumerable<CustomerDTO>> GetAll()
        {
            try
            {
                var locations = _unitOfWork.Customer.GetAll();
                return locations ?? throw new ApplicationException("No Cities found");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public Task<CustomerDTO> GetById(int id)
        {
            try
            {
                var locations = _unitOfWork.Customer.GetById(id);
                return locations ?? throw new ApplicationException("No City found");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
