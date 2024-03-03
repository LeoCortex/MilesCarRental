using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Models.Repository;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using AutoMapper;
using Models.Repository.Domain;

namespace DataAccess.Repository
{
    public abstract class Repository<TEntity> where TEntity : class
    {

        protected readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task Add(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add entity", ex);
            }
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update entity", ex);
            }
        }

        public virtual async Task<TEntity> Delete(TEntity entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity));
                }

                var isElementExis = await _context.Set<TEntity>().FindAsync(entity);
                if (isElementExis != null)
                {
                    _context.Set<TEntity>().Remove(entity);
                    await _context.SaveChangesAsync();
                    return entity;
                }
                else
                {
                    throw new ArgumentException($"Entity with key '{entity.GetHashCode()}' does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete entity", ex);
            }
        }
    }
}
