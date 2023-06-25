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
using UserManager.DbLib;
using UserManager.Models;

namespace UserManager.App
{
    public partial class MainWindow : Window
    {
        private readonly TableAccount _tableAccount;
        public MainWindow()
        {
            var connection = @"Data Source=C:\Users\naumo\source\repos\UserManager\SQL\account.db;";
            _tableAccount = new TableAccount(new TableAccountsSql(new TableOperationSqLite<Account>(connection)));
            
            InitializeComponent();
        }

        private void Button_Clear_OnClick(object sender, RoutedEventArgs e)
        {
            Input_Login.Clear();
            Input_Password.Clear();
        }

        private void Button_Auth_OnClick(object sender, RoutedEventArgs e)
        {
            var login = Input_Login.Text;
            var password = Input_Password.Text;

            MessageBox.Show(_tableAccount.CheckLoginPassword(login, password) ? "Вход разрешён" : "Вход запрещён");
        }
    }
}