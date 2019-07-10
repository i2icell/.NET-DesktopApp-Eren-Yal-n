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
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            System.Threading.Thread.Sleep(3000);
            InitializeComponent();
        }

        private void toCreateAccountPage(object sender, RoutedEventArgs e)
        {
            CreateAcccountPage pg = new CreateAcccountPage();
            this.Content = pg;
        }

        private void loginBtnFunction(object sender, RoutedEventArgs e)
        {
            UTIL.ServicesPortTypeClient client = new UTIL.ServicesPortTypeClient();
            int loginSuccess = client.login(phoneNum.Text, password.Password);
            

            if (loginSuccess == 1)
            {
                UserMainPage pg = new UserMainPage();
                pg.phoneNumLabel.Content = phoneNum.Text;
                pg.nameLabel.Content = client.showProfile(phoneNum.Text)[0] + " " + client.showProfile(phoneNum.Text)[1];
                pg.packageLabel.Content = client.showProfile(phoneNum.Text)[3];
                pg.internetLabel.Content = client.getBalances(phoneNum.Text)[0];
                pg.callLabel.Content = client.getBalances(phoneNum.Text)[1];
                pg.smsLabel.Content = client.getBalances(phoneNum.Text)[2];
                this.Content = pg;
                
            } else
            {
                invalidLabel.Content = "Geçersiz Telefon Numarası veya Şifre";
            }



        }

        private void forgotPassBtn(object sender, RoutedEventArgs e)
        {
            ForgotPasswordPage pg = new ForgotPasswordPage();
            this.Content = pg;
        }
    }
}
