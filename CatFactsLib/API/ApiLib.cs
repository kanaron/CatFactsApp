using System.Net.Http.Headers;

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
