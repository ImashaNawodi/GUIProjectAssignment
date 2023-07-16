using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class NormalUser
    {

        public string FullName { get; set; }
        public string Address { get; set; }
        public string Course { get; set; }

        public string EnrollKey { get; set; }
        public string NationalID { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }

        public NormalUser(string fullName, string address, string course, string entrollkey, string nationalid, string department, string email)
        {

            FullName = fullName;
            Address = address;
            Course= course;
            EnrollKey = entrollkey;
            NationalID = nationalid;
            Department = department;
            Email = email;

        }
        public NormalUser()
        {

        }
    }
}

