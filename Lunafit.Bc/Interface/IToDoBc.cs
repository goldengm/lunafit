using Lunafit.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lunafit.Bc.Interface
{
    public interface IToDoBc
    {
        Task<IEnumerable<ToDo>> GetAsync();
        Task<ToDo> GetByIdDbAsync(int id);
        Task<IEnumerable<ToDo>> GetDbAsync();

    }
}
