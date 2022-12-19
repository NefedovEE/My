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


namespace PUBLISHINGHOUSE
{
    /// <summary>
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            var db = new bdNefedovEntities();
           // ClientGrid.ItemsSource = db.Connection.Client.ToList();
            ClientGrid.ItemsSource = db.Book.ToList();
            ClientGrid.ItemsSource = db.Genre.ToList();
        }
    }
}
