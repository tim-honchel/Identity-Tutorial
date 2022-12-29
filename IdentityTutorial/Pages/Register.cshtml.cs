using IdentityTutorial.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityTutorial.Pages
{
    public class RegisterModel : PageModel
    {
        public Register Model { get; set; }
        public void OnGet()
        {
        }
    }
}
