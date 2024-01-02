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

namespace HW16_logIn
{
    public partial class MainWindow : Window
    {
        private string username = "admin";
        private string password = "admin";

        public MainWindow()
        {
            InitializeComponent();
        }

        private bool isLoginValid(string inputUsername, string inputPassword)
        {
            return inputUsername == username && inputPassword == password;
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            string login = usernameTextBox.Text;
            string passwd = passwordTextBox.Text;

            if (isLoginValid(login, passwd))
            {
                MessageBox.Show("Успішний вхід!");
            }
            else
            {
                MessageBox.Show("Некоректні дані для входу. Будь ласка, спробуйте знову.");
            }
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
