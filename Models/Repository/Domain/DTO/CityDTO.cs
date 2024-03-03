using Models.Repository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository.Domain.DTO;

public class CityDTO : ICity
{
    public int Id { get; set; }
    public int Code { get; set; }
    public string? Name { get; set; }
    public string? Comments { get; set; }

    //public static City ToCity(this ICity city)
    //{
    //    return new City
    //    {
    //        Id = city.Id,
    //        Code = city.Code,
    //        Name = city.Name,
    //        Comments = city.Comments
    //    };
    //}
    //public static List<City> ToCity(IEnumerable<ICity> cities)
    //{
    //    List<City> cityList = new List<City>();
    //    foreach (var city in cities)
    //    {
    //        cityList.Add(ToCity(city));
    //    }
    //    return cityList;
    //}
}
