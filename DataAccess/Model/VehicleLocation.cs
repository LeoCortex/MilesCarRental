using Models.Repository.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class VehicleLocation : IVehicleLocation
    {
        public int Id { get; set; }
        public int IdVehicle { get; set; }
        public int IdLocation { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }


    }
}
