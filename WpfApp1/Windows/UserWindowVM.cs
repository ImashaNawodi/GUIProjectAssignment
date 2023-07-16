
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using project02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Net;
using System.Reflection;
using WpfApp1.Windows;

namespace WpfApp1.Model
{

    public partial class NormalUserVM : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        [ObservableProperty]
        public string fullname;

        [ObservableProperty]
        public string address;

        [ObservableProperty]
        public string course;
        [ObservableProperty]
        public string nationalid;
        [ObservableProperty]
        public string enrollKey;

        [ObservableProperty]
        public string department;

        [ObservableProperty]
        public string email;

        [ObservableProperty]
        public string title;

        public NormalUserVM(NormalUser u)
        {
            Student = u;

            fullname = Student.FullName;
            address = Student.Address;
            course = Student.Course;
            enrollKey = Student.EnrollKey;
            department= Student.Department;
            
            nationalid = Student.NationalID;
            
            email = Student.Email;




        }
        public NormalUserVM()
        {

        }




        public NormalUser Student { get; private set; }
        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void Save()
        {

            if (Student == null)
            {

                Student = new NormalUser()
                {
                    FullName = fullname,
                    Address = address,
                    Course = course,
                    EnrollKey = enrollKey,

                    Department = department,
                    NationalID = nationalid,
                    
                    Email = email

                };


            }
            else
            {
                Student.FullName = fullname;
                Student.Address = address;
                Student.Course = course;
                Student.EnrollKey = enrollKey;
                Student.Department = department;    
                Student.NationalID = nationalid;   
                Student.Email = email;
                
                



            }

            if (Student.FullName != null)
            {

                CloseAction();
            }
            Application.Current.MainWindow.Show();


        }
    }
}
