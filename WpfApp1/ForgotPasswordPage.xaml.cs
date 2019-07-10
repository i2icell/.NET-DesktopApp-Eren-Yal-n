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
    /// Interaction logic for ForgotPasswordPage.xaml
    /// </summary>
    public partial class ForgotPasswordPage : Page
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private void ChangePassBtn(object sender, RoutedEventArgs e)
        {
            UTIL.ServicesPortTypeClient client = new UTIL.ServicesPortTypeClient();
            if (client.changePassword(PhoneNum.Text, TCNo.Text, newPassword.Password) == 1)
            {
                MainWindow wd = new MainWindow();
                wd.AccCreated.Content = "Şifre Başarıyla Değiştirildi!";
                Application.Current.Windows[0].Close();
                wd.ShowDialog();
            }
            else
            {
                invalidLabel.Content = "Lütfen Geçerli Bilgiler Giriniz!";
            }
        }

        private void BackBtn(object sender, RoutedEventArgs e)
        {
            MainWindow wd = new MainWindow();
            Application.Current.Windows[0].Close();
            wd.ShowDialog();
        }
    }
}
