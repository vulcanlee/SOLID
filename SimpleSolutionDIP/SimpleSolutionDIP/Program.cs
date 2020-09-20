using System;

namespace SimpleSolutionDIP
{
    class Program 
    {
        static void Main(string[] args)
        {
            var myService = new LoginService();
            SecurityService service = new SecurityService(myService);
            var isSuccess = service.LoginUser("Vulcan", "000");
            Console.WriteLine("身分驗證" + (isSuccess == true ? "成功" : "失敗"));
        }
    }
    public class SecurityService
    {
        private readonly ILoginService _LoginService;

        public SecurityService(ILoginService loginService)
        {
            this._LoginService = loginService;
        }

        public bool LoginUser(string userName, string password)
        {
            return _LoginService.ValidateUser(userName, password);
        }
    }

    public interface ILoginService
    {
        bool ValidateUser(string userName, string password);
    }

    public class LoginService : ILoginService
    {
        public bool ValidateUser(string userName, string password)
        {
            if (userName == "Vulcan" && password == "123") return true;
            else return false;
        }
    }
}
