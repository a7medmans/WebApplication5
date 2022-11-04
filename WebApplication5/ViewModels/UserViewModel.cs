using System.Runtime.ExceptionServices;
using System.Collections.Generic;



namespace WebApplication5.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public IEnumerable<string> Roles { get; set; }

    }
}
