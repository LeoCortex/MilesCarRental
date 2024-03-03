using Models.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository.Domain.DTO;

public class CustomerDTO : ICustomer
{
    public int Id { get; set; }
    public int Identification { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int PhoneNumber { get; set; }
    public int IdCity { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
}
