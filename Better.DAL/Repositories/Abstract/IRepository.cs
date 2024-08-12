using Better.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.DAL.Repositories.Abstract
{
    public interface IRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity);
    }
}
