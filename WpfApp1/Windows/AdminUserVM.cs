using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;


namespace WpfApp1.Windows
{
    
    public partial class AdminUserVM : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        [ObservableProperty]
        public string userName;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        public string fullName;
        [ObservableProperty]
        public string department;
        
        [ObservableProperty]
        public string email;

        [ObservableProperty]
        public string title;

        public AdminUserVM(AdminUser a)
        {
            Admin = a;

            userName=Admin.UserName;
            password = Admin.Password;
            fullName = Admin.FullName;
            department = Admin.Department;
            email = Admin.Email;




        }
        public AdminUserVM()
        {

        }




        public AdminUser Admin { get; private set; }
        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void Save()
        {

            if (Admin == null)
            {

                Admin = new AdminUser()
                {
                    UserName = userName,
                    Password = password,
                    FullName = fullName,
                    Department = department,
                    Email = email
                };


            }


            
            else
            {
                Admin.UserName = userName;
                Admin.Password = password;
                Admin.FullName= fullName;
                Admin.Department = department;
                Admin.Email = email;

            }

            


        }
    }
}


