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

namespace PomodoroTaskManagerApp
{
    /// <summary>
    /// Логика взаимодействия для SignUpForm.xaml
    /// </summary>
    public partial class SignUpForm : Window
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void SignUPBtn_Click(object sender, RoutedEventArgs e)
        {
            string Ulogin = TBULogin.Text.Trim();
            string UFName = TBUFName.Text.Trim();
            string ULName = TBULName.Text.Trim();   
            string UPass = PBUPass.Password.Trim();
            string UPassConfirmed = PBUPassConfirm.Password.Trim();
            if (Ulogin.Length < 5) 
            {
                TBULogin.ToolTip = "Это поле введено не корректно!";
                TBULogin.Background = Brushes.DarkRed;
            }
            else if(UPass.Length< 5)
            {
                PBUPass.ToolTip = "Это поле введено не корректно!";
                PBUPass.Background = Brushes.DarkRed;
            }
                 
            else if (UPass != UPassConfirmed)
            {
                PBUPassConfirm.ToolTip = "Это поле введено не корректно!";
                PBUPassConfirm.Background = Brushes.DarkRed;
            }
            else
            {
                TBULogin.ToolTip = " ";
                TBULogin.Background = Brushes.Transparent;
                PBUPass.ToolTip = " ";
                PBUPass.Background = Brushes.Transparent;
                PBUPassConfirm.ToolTip = " ";
                PBUPassConfirm.Background = Brushes.Transparent;
            }

        }
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi", "message", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
