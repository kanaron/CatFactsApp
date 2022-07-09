using CatFactsLib.API;
using CatFactsLib.CatFact;

namespace CatFactsLib.ApplicationProcessor
{
    public class ApplicationProcessor : IApplicationProcessor
    {
        public ApiLib Api { get; set; }

        public ApplicationProcessor()
        {
            Initialize();
        }

        public void Initialize()
        {
            if (Api == null)
                Api = new();
        }

        public async Task<string> GetFact()
        {
            return await CatFactProcessor.LoadCatFact();
        }

    }
}
