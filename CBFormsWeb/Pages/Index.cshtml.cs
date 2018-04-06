using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ooui.AspNetCore;
using Xamarin.Forms;

namespace CBFormsWeb.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            return new ElementResult(new MainPage().GetOouiElement());
        }
    }
}
