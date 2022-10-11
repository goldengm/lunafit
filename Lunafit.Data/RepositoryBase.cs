using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunafit.Data
{
    public class RepositoryBase<T> where T : class
    {
        protected readonly LunafitDbContext _dbContext;
        protected DbSet<T> Dbset;
        public RepositoryBase(LunafitDbContext dbContext)
        {
            _dbContext = dbContext;
            Dbset = dbContext.Set<T>();
        }
    }
}
