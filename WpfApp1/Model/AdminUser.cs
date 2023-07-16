using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class AdminUser
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public string Department { get; set; }
        
        public string Email { get; set; }

        public AdminUser(string userName, string password, string fullName, string department, string email)
        {

            UserName = userName;
            Password = password;
            FullName=fullName;
            Department = department;
            Email=email;


            

        }
        public AdminUser()
        {

        }
    }
}
