using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository.Domain;

public interface IRental
{
    public int Id { get; set; }
    public int Code { get; set; }
    public int IdCustomer { get; set; }
    public int IdLocationOri { get; set; }
    public int IdLocationDes { get; set; }
    public DateTime DateOri { get; set; }
    public DateTime DateDes { get; set; }
    public int IdVehicle { get; set; }
    public int IdState { get; set; }

}
