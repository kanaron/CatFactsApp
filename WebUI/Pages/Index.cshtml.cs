using CatFactsLib.ApplicationProcessor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebUI.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Fact { get; set; }

        ApplicationProcessor application = new();

        public void OnGet()
        {

        }
    }
}