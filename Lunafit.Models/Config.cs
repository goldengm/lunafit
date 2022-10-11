using System;
using System.Collections.Generic;
using System.Text;

namespace Lunafit.Models
{
    public class Config
    {
        public static class ServiceEndPoints
        {
            public static string ExternalServiceEndpoint { get; set; }
            public static string ConnectionString { get; set; }
        }
    }
}
