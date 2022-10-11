using Lunafit.Data.Repositories.IRepositories;
using Lunafit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunafit.Data.Repositories
{
    public class ToDoRepository : Repository<ToDo>, IToDoRepository
    {
        public ToDoRepository(LunafitDbContext lunafitDbContext) : base(lunafitDbContext)
        {

        }
       
    }
}
