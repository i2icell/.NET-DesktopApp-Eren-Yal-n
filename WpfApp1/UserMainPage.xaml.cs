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

namespace WpfApp1
{
    /// <summary>
    /// UserMainPage.xaml etkileşim mantığı
    /// </summary>
    public partial class UserMainPage : Page
    {
        
        public UserMainPage()
        {
            InitializeComponent();
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Hesabınızdan çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MainPage pg = new MainPage();
                    Application.Current.MainWindow.Content = pg;
                    break;
                case MessageBoxResult.No:

                    break;
            }
        }
    }
}
