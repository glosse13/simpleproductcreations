using Microsoft.EntityFrameworkCore;
using SimpleProductCreation.Core;
using SimpleProductCreation.Domain.Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductCreation.Infrastructure.Data.Repositories
{
    public class DbContextRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        private readonly DataContext context;

        public DbContextRepository(DataContext context)
        {
            this.context = context;
        }

        public T Add(T entity)
        {
            try
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();

                return entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return context.Set<T>().Where(predicate);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IReadOnlyList<T> ListAll()
        {
            try
            {
            return context.Set<T>().ToList();
            }
            catch (Exception ex)
            {
               throw;
            }
        }
    }
}
