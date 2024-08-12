using Better.Core.Entities;
using Better.DAL.Context;
using Better.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Better.DAL.Repositories.Concrete
{
    public class Repository<T>  :IRepository<T> where T: class, IEntityBase, new()
    {
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }



        public async Task AddAsync(T entity)
        {
           await Table.AddAsync(entity);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
    }
}
//Task = void 