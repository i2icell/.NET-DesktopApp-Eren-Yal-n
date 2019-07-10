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
            MessageBoxResult result = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MainWindow wd = new MainWindow();
                    Application.Current.Windows[0].Close();
                    wd.ShowDialog();
                    break;
                case MessageBoxResult.No:

                    break;
            }
        }
    }
}
