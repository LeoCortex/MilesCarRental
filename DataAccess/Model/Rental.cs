using Models.Repository.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Rental : IRental
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
}
