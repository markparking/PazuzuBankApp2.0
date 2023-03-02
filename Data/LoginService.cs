namespace PazuzuBankApp.Data
{
    public class LoginService
    {
        public bool Login(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
