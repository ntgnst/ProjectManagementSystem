namespace PMS.WEB.UI.Models
{
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public bool Result { get; set; }
        public string ReturnUrl { get; set; }
        public LoginViewModel(string returnUrl)
        {
            ReturnUrl = returnUrl;
            Result = true;
        }
        public LoginViewModel()
        {
            Result = true;
        }
    }
}
