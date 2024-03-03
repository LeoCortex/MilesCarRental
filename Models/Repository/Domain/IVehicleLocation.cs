using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository.Domain;

public interface IVehicleLocation
{
    public int Id { get; set; }
    public int IdVehicle { get; set; }
    public int IdLocation { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime? ExitDate { get; set; }

}
