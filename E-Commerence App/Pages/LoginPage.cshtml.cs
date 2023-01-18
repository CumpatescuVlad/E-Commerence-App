using E_Commerence_App.Modeles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerence_App.Pages
{
    public class LoginPageModel : PageModel
    {
        [BindProperty]

        public LoginModel Credentials { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost() 
        {
            

            //System.IO.File.WriteAllText($@"{Environment.CurrentDirectory}\User.txt",$"User Logges In As {Credentials.UserName} {Credentials.Password}");

           return RedirectToPage("/Account");
        }    
    }
}
