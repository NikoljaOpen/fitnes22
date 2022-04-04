using Fitnes2.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fitnes2.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientiesPage.xaml
    /// </summary>
    public partial class ClientiesPage : Page
    {
        public ClientiesPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using(var db = new FitnesDataBaseEntities())
            {
                ClientiesTable.ItemsSource = db.Users.ToList();
            }

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new FitnesDataBaseEntities())
            {
                var client = (Users)ClientiesTable.SelectedItem;
                db.Entry(client).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                ClientiesTable.ItemsSource = db.Users.ToList();
            }
        }
    }
}
