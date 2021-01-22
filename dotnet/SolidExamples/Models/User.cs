using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void GenerateUserReport(User user)
        {
            //generate report about a user
        }
    }
}
