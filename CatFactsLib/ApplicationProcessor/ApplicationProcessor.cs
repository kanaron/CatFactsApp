using CatFactsLib.API;
using CatFactsLib.CatFact;

namespace CatFactsLib.ApplicationProcessor
{
    public class ApplicationProcessor : IApplicationProcessor
    {
        public ApiLib Api { get; set; }

        public void Initialize()
        {
            ApiLib api = new();
        }

        public async Task<string> GetFact()
        {
            return await CatFactProcessor.LoadCatFact();
        }

    }
}
