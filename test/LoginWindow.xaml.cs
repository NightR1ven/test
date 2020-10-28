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
using test.Models;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }


        private void BtnExit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnEnter(object sender, RoutedEventArgs e)
        {
            using (LogTestEntities db = new LogTestEntities())
            {
                Login x = db.Logins.FirstOrDefault(item => item.LogT == textLog.Text);

                    if (!(x is null))
                    {
                    if (x.PasT==pasBox.Password)
                    {
                        int Rol =(int)x.id_Profal;
                        string Nick = (string)x.LogT;
                        MainWindow mainWindow = new MainWindow(Rol,Nick);
                        mainWindow.Owner = this;
                        this.Hide();
                        mainWindow.Show();

                    }
                    else
                    {
                        MessageBox.Show("Не верный пароль!");
                    }

                    }
                else
                {
                    MessageBox.Show("Не верный логин!");
                }


            }
        }
    }
}
