using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CatFactsLib.API
{
    public class ApiLib
    {
        public static HttpClient ApiClient { get; set; }

        public ApiLib()
        {
            Initialize();
        }

        public void Initialize()
        {
            ApiClient = new();
            ApiClient.BaseAddress = new Uri("https://catfact.ninja/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}
