using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Code
{
    public class FakeAppUserRepository : IAppUser
    {
        private static Dictionary<int, AppUser> Users;

        public FakeAppUserRepository()
        {

            if(Users == null)
            {
                Users = new Dictionary<int, AppUser>();

                Users.Add(1, new AppUser
                {
                    UserName = "Naulca",
                    Password = "password",
                    FirstName = "Raquel",
                    LastName = "Meyer",
                    EmailAddress = "raquel.meyer@trojans.dsu.edu",
                    IsAuthenticated = true

                    
                    
                });
                Users.Add(2, new AppUser
                {
                    UserName = "AnnaF",
                    Password = "password",
                    FirstName = "Anna",
                    LastName = "Fields",
                    EmailAddress = "anna.fields@trojans.dsu.edu",
                    IsAuthenticated = true



                });
                Users.Add(3, new AppUser
                {
                    UserName = "Iroh007",
                    Password = "password",
                    FirstName = "Sandesh",
                    LastName = "Sharma",
                    EmailAddress = "sandesh.sharma@trojans.dsu.edu",
                    IsAuthenticated = true



                });
            }

        }

        public bool Login(string Username, string Password)
        {
           
        }
        public List<AppUser> GetAll()
        {
            
        }
        public void SetAuthentication(string Username, bool IsAuthenticated)
        {

        }
      
        

        public AppUser GetByUserName(string UserName)
        {

        }
    }
}
