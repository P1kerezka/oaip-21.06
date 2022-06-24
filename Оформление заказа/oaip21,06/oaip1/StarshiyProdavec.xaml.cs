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
using System.Windows.Shapes;

namespace oaip1
{
    /// <summary>
    /// Логика взаимодействия для StarProd.xaml
    /// </summary>
    public partial class StarshiyProdavec : Window
    {
        public StarshiyProdavec()
        {
            InitializeComponent();
        }
        private void Button_back2(object sender, RoutedEventArgs e)
        {
            MainWindow windowmain = new MainWindow();
            windowmain.Show();
            Close();

        }
    }
}
