using Lunafit.Models;
using Lunafit.Service.Interface;
using System;
using System.Net.Http;
using System.Text;

namespace Lunafit.Service
{
    public class WebApiCall : IWebApiCall
    {

        public WebApiCall()
        {

        }
        public HttpResponseMessage CallPostAPI(string apiUri, string jsonData)
        {
            using (var handler = new HttpClientHandler())
            {
                using (var client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(Config.ServiceEndPoints.ExternalServiceEndpoint + apiUri);

                    HttpResponseMessage apiResponse = client.PostAsync("", new StringContent(jsonData, Encoding.UTF8, "application/json")).Result;

                    apiResponse.EnsureSuccessStatusCode();
                    return apiResponse;
                }
            }
        }

        public HttpResponseMessage CallPutAPI(string apiUri, string jsonData)
        {
            using (var handler = new HttpClientHandler())
            {
                using (var client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(Config.ServiceEndPoints.ExternalServiceEndpoint + apiUri);

                    HttpResponseMessage apiResponse = client.PutAsync("", new StringContent(jsonData, Encoding.UTF8, "application/json")).Result;

                    apiResponse.EnsureSuccessStatusCode();
                    return apiResponse;
                }
            }
        }

        public HttpResponseMessage CallDeleteAPI(string apiUri)
        {
            using (var handler = new HttpClientHandler())
            {
                using (var client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(Config.ServiceEndPoints.ExternalServiceEndpoint + apiUri);

                    HttpResponseMessage apiResponse = client.DeleteAsync("").Result;

                    apiResponse.EnsureSuccessStatusCode();
                    return apiResponse;
                }
            }
        }
        public HttpResponseMessage CallGetAPI(string apiUri)
        {
            using (var handler = new HttpClientHandler())
            {
                using (var client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(Config.ServiceEndPoints.ExternalServiceEndpoint + apiUri);

                    HttpResponseMessage apiResponse = client.GetAsync("").Result;

                    apiResponse.EnsureSuccessStatusCode();
                    return apiResponse;
                }
            }
        }
    }
}
