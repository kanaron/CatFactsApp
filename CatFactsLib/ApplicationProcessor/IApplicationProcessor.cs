using CatFactsLib.API;

namespace CatFactsLib.ApplicationProcessor
{
    public interface IApplicationProcessor
    {
        ApiLib Api { get; set; }

        Task<string> GetFact();
        void Initialize();
    }
}