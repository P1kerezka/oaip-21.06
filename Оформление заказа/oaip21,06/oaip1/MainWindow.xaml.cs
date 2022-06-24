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

namespace oaip1
{
    /// <summary>
    /// Interaction logic for oaip1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.IsChecked.Value)
            {
                Text_password.Text = PasswordBoxPassword.Password;
                PasswordBoxPassword.Visibility = Visibility.Hidden;
                Text_password.Visibility = Visibility.Visible;

            }
            else
            {
                PasswordBoxPassword.Password = Text_password.Text;
                Text_password.Visibility = Visibility.Hidden;
                PasswordBoxPassword.Visibility = Visibility.Visible;
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string[] logins = new string[3] { "Prodavec", "starshiy", "Admin" };
            string[] password = new string[3] { "Prodavec", "starshiy", "Admin" };
            if (Text_login.Text.Equals(logins[0]) & Text_password.Text.Equals(password[0]) | PasswordBoxPassword.Password.Equals(password[0]))
            {
                Prodavec winprodavec = new Prodavec();
                winprodavec.Show();
                Close();
            }
            else if (Text_login.Text.Equals(logins[1]) & Text_password.Text.Equals(password[1]) | PasswordBoxPassword.Password.Equals(password[1]))
            {
                StarshiyProdavec winstarshiy = new StarshiyProdavec();
                winstarshiy.Show();
                Close();
            }
            else if (Text_login.Text.Equals(logins[2]) & Text_password.Text.Equals(password[2]) | PasswordBoxPassword.Password.Equals(password[2]))
            {
                Admin winadmin = new Admin();
                winadmin.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }

        }
    }
}