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

namespace test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(int x, string n)
        {
            InitializeComponent();

            switch (x)
            {
                case 1:
                    menuFrame.NavigationService.Navigate(new Uri("Pages/Page1.xaml", UriKind.Relative));
                    break;

                case 2:
                    menuFrame.NavigationService.Navigate(new Uri("Pages/Page2.xaml", UriKind.Relative));
                    break;
            }


            Nick.Content = n;        
        }

        private void WinClosed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
