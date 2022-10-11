using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Lunafit.Service.Interface
{
    public interface IWebApiCall
    {
        HttpResponseMessage CallPostAPI(string apiUri, string jsonData);
        HttpResponseMessage CallPutAPI(string apiUri, string jsonData);
        HttpResponseMessage CallDeleteAPI(string apiUri);
        HttpResponseMessage CallGetAPI(string apiUri);

    }
}
