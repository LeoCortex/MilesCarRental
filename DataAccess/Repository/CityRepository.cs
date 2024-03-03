using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Context;
using DataAccess.Model;
using Models.Repository.Domain.DTO;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace DataAccess.Repository;

class CityRepository : ICityRepository
{
    protected readonly DataContext _context;
    private readonly IMapper _mapper;

    public CityRepository(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CityDTO>> GetAll()
    {
        try
        {
            var query = _context.Set<City>();
            var result = _mapper.Map<List<CityDTO>>(_context.Set<City>());
            return await Task.FromResult(result);
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to update entity", ex);
        }
    }

    public async Task<CityDTO> GetById(int id)
    {
        try
        {
            var query = _context.Set<City>().FirstOrDefaultAsync(x => x.Id == id);
            var result = _mapper.Map<CityDTO>(query);
            return await Task.FromResult(result);
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to update entity", ex);
        }
    }

    public async Task Add(CityDTO NewCity)
    {
        try
        {
            await _context.Set<City>().AddAsync(_mapper.Map<City>(NewCity));
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to add entity", ex);
        }
    }

    public async Task<CityDTO> Delete(CityDTO city)
    {
        try
        {
            

            var isElementExis = await _context.Set<City>().FindAsync(city);
            if (isElementExis != null)
            {
                _context.Set<City>().Remove(_mapper.Map<City>(city));
                await _context.SaveChangesAsync();
                return city;
            }
            else
            {
                throw new ArgumentException($"Entity with key '{city.GetHashCode()}' does not exist");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to delete entity", ex);
        }
    }


    public async Task<CityDTO> Update(CityDTO city)
    {
        try
        {
            _context.Set<City>().Update(_mapper.Map<City>(city));
            await _context.SaveChangesAsync();
            return city;
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to update entity", ex);
        }
    }
}
