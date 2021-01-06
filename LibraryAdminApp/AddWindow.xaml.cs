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
using System.Windows.Shapes;

namespace LibraryAdminApp
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void Add_author_Ckick(object sender, RoutedEventArgs e)
        {
            string k = Fullname_author_TBox.Text.ToString();
            string sql2 = $@"INSERT INTO authors (fullname) values(N'{k}')";
            string СonnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(СonnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql2, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Author has been added");
        }

        private void Add_book_Click(object sender, RoutedEventArgs e)
        {
            string author_id = (Authors_id_TBox.Text != "") ? Authors_id_TBox.Text.ToString() : "3";
            string title = (Title_TBox.Text != "") ? Title_TBox.Text.ToString() : "unknown";
            string count = (Count_TBox.Text != "") ? Count_TBox.Text.ToString() : "0";
            string price = (Price_TBox.Text != "") ? Price_TBox.Text.ToString() : "0";
            string sql3 = $@"INSERT INTO books (title, author_id, Books_Count, price) values(N'{title}',{author_id},{count},{price})";
            string СonnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(СonnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql3, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Book has been added");
            }
            catch(Exception)
            {
                MessageBox.Show("you entered something wrong");
            }
                connection.Close();
        }
    }
}
