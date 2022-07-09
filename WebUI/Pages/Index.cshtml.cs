using CatFactsLib.ApplicationProcessor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebUI.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string CatFact { get; set; }

        IApplicationProcessor applicationProcessor = new ApplicationProcessor();

        public async Task<IActionResult> OnGetAsync()
        {
            CatFact = await applicationProcessor.GetFact();
            return Page();
        }
    }
}