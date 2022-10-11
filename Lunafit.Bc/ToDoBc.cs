using Lunafit.Bc.Interface;
using Lunafit.Data.Repositories.IRepositories;
using Lunafit.Models;
using Lunafit.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace Lunafit.Bc
{
    public class ToDoBc : IToDoBc
    {
        private readonly IToDoRepository _toDoRepository;
        private readonly IWebApiCall _webApiCall;
        public ToDoBc(IWebApiCall webApiCall, IToDoRepository toDoRepository)
        {
            _webApiCall = webApiCall;
            _toDoRepository = toDoRepository;
        }
        public async Task<IEnumerable<ToDo>> GetAsync()
        {
            HttpResponseMessage apiResponse = _webApiCall.CallGetAPI($"{Constants.ToDoListUrl}");
            var apiData = await apiResponse.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<IEnumerable<ToDo>>(apiData);
            await _toDoRepository.Insert(result.Select(s=>new ToDo { Title=s.Title,UserId=s.UserId, Completed=s.Completed }).ToList());//Saving data to the database.
            return result;
        }

        //This method is for getting the data from database which was stored from get external API
        public async Task<IEnumerable<ToDo>> GetDbAsync()
        {
            return await _toDoRepository.GetAll();
        }
        public async Task<ToDo> GetByIdDbAsync(int id)
        {
            return await _toDoRepository.GetByID(id);
        }
    }
}
