using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Code
{
    public interface IAppUser
    {
        bool Login(string UserName, string Password);
        List<AppUser> GetAll();

        void SetAuthentication(string Username, bool IsAuthenticated);

        AppUser GetByUserName(string UserName);




    }


}
