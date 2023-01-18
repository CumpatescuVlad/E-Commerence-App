using E_Commerence_App.Modeles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Commerence_App.Pages
{
    public class AccountPageModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }
        //public LoginModel Credentials { get; set; }
        
        public void OnGet(string username)
        {
            username = UserName;
        }
    }
}
