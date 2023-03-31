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

namespace Test11_20.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistWindow.xaml
    /// </summary>
    public partial class RegistWindow : Window
    {
        public RegistWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePassword(textBox1.Text) && ValidateLogin(textBox.Text))
            {
                CalcWindow calcWindow = new CalcWindow();
                this.Close();
                calcWindow.Show();
            }
        }

        // Подтверждение пароля
        public bool ValidatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 35)
            {
                return false;
            }

            if (!password.Any(Char.IsLower))
            {
                return false;
            }

            if (!password.Any(Char.IsUpper))
            {
                return false;
            }

            if (!password.Any(Char.IsDigit))
            {
                return false;
            }

            if (password.Intersect("!@#$%^&*?").Count() == 0)
            {
                return false;
            }
            return true;
        }


        // Подтверждение логина
        public static bool ValidateLogin(string login)
        {
            if (!login.EndsWith(".calcul"))
            {
                return false;
            }

            if (login.Replace(".calcul", "").Length < 10 || login.Length > 35)
            {
                return false;
            }

            if (!login.Any(Char.IsLower))
            {
                return false;
            }

            if (!login.Any(Char.IsUpper))
            {
                return false;
            }

            if (!login.Any(Char.IsDigit))
            {
                return false;
            }

            if (login.Replace(".calcul", "").Intersect("!@#$%^&*?").Count() == 0)
            {
                return false;
            }
            
            return true;
        }
    }
}
