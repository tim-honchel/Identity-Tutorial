using IdentityTutorial.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace IdentityTutorial.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        [BindProperty]
        public Login Model { get; set; }
        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost(string returnUrl=null) 
        {
            if (ModelState.IsValid)
            {
                var identityResult = await _signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);
                if (identityResult.Succeeded) 
                {
                    if (returnUrl == null || returnUrl == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }

                }
            }
            ModelState.AddModelError("","Username or password incorrect");
            return Page();
        }
    }
}
