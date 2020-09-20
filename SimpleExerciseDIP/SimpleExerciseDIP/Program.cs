using System;

namespace SimpleExerciseDIP
{
    class Program
    {
        static void Main(string[] args)
        {
            SecurityService service = new SecurityService();
            var isSuccess = service.LoginUser("Vulcan", "000");
            Console.WriteLine("身分驗證"+(isSuccess==true?"成功":"失敗"));
        }
    }
    public class SecurityService
    {
        public bool LoginUser(string userName, string password)
        {
            LoginService service = new LoginService();
            return service.ValidateUser(userName, password);
        }
    }

    public class LoginService
    {
        public bool ValidateUser(string userName, string password)
        {
            if (userName == "Vulcan" && password == "123") return true;
            else return false;
        }
    }
}
