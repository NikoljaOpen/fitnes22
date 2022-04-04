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
using AutorizationLibrary;
using Fitnes2.Views.Windows;

namespace Fitnes2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = AutorizationClass.Check(LoginBox.Text, PasswordBox.Password, "admin1", "admin1");
            Message.Content = message;
            if(message== "Выполняется вход")
            {
                RootWindow window = new RootWindow();
                window.Show();
                this.Close();
            }
        }
    }
}
