using Newtonsoft.Json;
using System;

namespace Lunafit.Models
{
  
    public class ResponseModel
    {
        [JsonProperty(PropertyName = "state")]
        public RequestState State { get; set; }
        [JsonProperty(PropertyName = "msg")]
        public string Msg { get; set; }
        [JsonProperty(PropertyName = "data")]
        public dynamic Data { get; set; }
        public static string success = "Success";
        public static string fail = "Failed";

        public ResponseModel()
        {
            State = RequestState.Success;
            Msg = ResponseModel.success;
        }
    }

    public enum RequestState
    {
        Failed = 500,
        NotAuth = 401,
        Success = 1,
        NotFound = 404,
        DataConcurrency = 100,
        Deleted = 205,
        BadRequest = 400,
        Forbidden = 403
    }
}
