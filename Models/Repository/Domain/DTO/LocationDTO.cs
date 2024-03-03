using Models.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository.Domain.DTO;

public class LocationDTO : ILocation
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string Name { get; set; }
    public int PhoneNumber { get; set; }
    public int IdCity { get; set; }
    public int IdArea { get; set; }

}
