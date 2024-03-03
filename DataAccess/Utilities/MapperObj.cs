using AutoMapper;
using Models.Repository.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Utilities;

public class MapperObj : Profile
{

    public MapperObj() 
    {
        CreateMap<DataAccess.Model.Area, AreaDTO >();
        CreateMap<AreaDTO, DataAccess.Model.Area > ();

        CreateMap<DataAccess.Model.City, CityDTO>();
        CreateMap<CityDTO, DataAccess.Model.City>();

        CreateMap<CustomerDTO, DataAccess.Model.Customer>();
        CreateMap<DataAccess.Model.Customer, CustomerDTO>();

        CreateMap<LocationDTO, DataAccess.Model.Location>();
        CreateMap<DataAccess.Model.Location, LocationDTO>();

        CreateMap<RentalDTO, DataAccess.Model.Rental>();
        CreateMap<DataAccess.Model.Rental, RentalDTO>();

        CreateMap<StateDTO, DataAccess.Model.State>();
        CreateMap<DataAccess.Model.State, StateDTO>();

        CreateMap<VehicleDTO, DataAccess.Model.Vehicle>();
        CreateMap<DataAccess.Model.Vehicle, VehicleDTO>();

        CreateMap<VehicleLocationDTO, DataAccess.Model.VehicleLocation>();
        CreateMap<DataAccess.Model.VehicleLocation, VehicleLocationDTO>();
    }
}
