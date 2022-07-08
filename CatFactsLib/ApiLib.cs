using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CatFactsLib
{
    public sealed class ApiLib
    {
        private static ApiLib _instance;

        public static HttpClient ApiClient { get; set; }

        private ApiLib()
        {

        }

        public static ApiLib GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ApiLib();
            }
            return _instance;
        }

        public static void Initialize()
        {
            ApiClient = new();
            ApiClient.BaseAddress = new Uri("https://catfact.ninja/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}
