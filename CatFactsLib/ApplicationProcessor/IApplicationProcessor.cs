using CatFactsLib.API;

namespace CatFactsLib.ApplicationProcessor
{
    public interface IApplicationProcessor
    {
        ApiLib Api { get; set; }

        void Initialize();
    }
}