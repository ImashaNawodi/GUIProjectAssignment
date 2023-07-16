using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Windows;

namespace project02
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Text;

            using (var context = new ProjectDbContext())
            {
                Users user = context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    if (user.Userrole == "Admin")
                    {
                        AdminWindow adminMainWindow = new AdminWindow();
                        adminMainWindow.Show();
                    }

                }
                else
                {
                    Console.WriteLine("Admin is null. Please provide a valid .");

                }


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Text;

            using (var context = new ProjectDbContext())
            {
                Users user = context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    if (user.Userrole == "User")
                    {
                        UserWindow normalUserMainWindow = new UserWindow();
                        normalUserMainWindow.Show();
                    }

                }
                else
                {
                    Console.WriteLine("User is null. Please provide a valid user.");

                }



            }

        }
    }


}
