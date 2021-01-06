using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Configuration;

namespace LibraryAdminApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Books> BookGridList = new List<Books>();
        public MainWindow()
        {
            InitializeComponent();
            string СonnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(СonnectionString);
            SqlCommand command = new SqlCommand(ConnectionClass.sql1, connection);
            connection.Open();
            SqlDataReader stringReader = command.ExecuteReader();

            while (stringReader.Read())
            {
                BookGridList.Add(new Books(String.Format("{0}", stringReader[0]), String.Format("{0}", stringReader[1]), String.Format("{0}", stringReader[2]),
                                           String.Format("{0}", stringReader[3]), String.Format("{0}", stringReader[4]), String.Format("{0}", stringReader[5])));
            }
            connection.Close();
        }

        private void BookGrid_Loaded(object sender, RoutedEventArgs e) 
        {
            BooksGrid.ItemsSource = BookGridList;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddWindow win = new AddWindow();
            win.Show();
        }

        private void Change_Click(object sender, RoutedEventArgs e) 
        {
            EditWindow newWin = new EditWindow();
            newWin.Show();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            string СonnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(СonnectionString);
            SqlCommand command = new SqlCommand(ConnectionClass.sql1, connection);
            connection.Open();
            SqlDataReader stringReader = command.ExecuteReader();
            BookGridList.Clear();

            while (stringReader.Read())
            {
                BookGridList.Add(new Books(String.Format("{0}", stringReader[0]), String.Format("{0}", stringReader[1]), String.Format("{0}", stringReader[2]),
                                           String.Format("{0}", stringReader[3]), String.Format("{0}", stringReader[4]), String.Format("{0}", stringReader[5])));
            }
            connection.Close();
            BooksGrid.ItemsSource = BookGridList;
            BooksGrid.Items.Refresh();
        }
    }
}