using Models.Repository.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Location : ILocation
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string? Name { get; set; }
        public int PhoneNumber { get; set; }
        public int IdCity { get; set; }
        public int IdArea { get; set; }

        
    }
}
