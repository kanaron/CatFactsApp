using CatFactsLib.API;
using CatFactsLib.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactsLib.CatFact
{
    public static class CatFactProcessor
    {
        public static async Task<string> LoadCatFact()
        {

            CatFactModel model = await GetFactFromWeb();

            FileProcessor.AddToFile(model.Fact);

            return model.Fact;
        }

        private static async Task<CatFactModel> GetFactFromWeb()
        {
            string function = "fact";

            using (HttpResponseMessage response = await ApiLib.ApiClient.GetAsync(function))
            {
                if (response.IsSuccessStatusCode)
                {
                    CatFactModel model = await response.Content.ReadAsAsync<CatFactModel>();

                    return model;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
