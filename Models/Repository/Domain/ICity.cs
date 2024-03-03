using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository.Domain;

public interface ICity
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string? Name { get; set; }
    public string? Comments { get; set; }
}
