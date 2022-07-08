using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactsLib
{
    public class CatFactProcessor
    {
        public static async Task<CatFactModel> LoadFact()
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
