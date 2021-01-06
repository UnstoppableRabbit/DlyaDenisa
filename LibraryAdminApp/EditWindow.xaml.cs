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
using System.Data.SqlClient;
namespace LibraryAdminApp
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }

        private void Edit_book_Click(object sender, RoutedEventArgs e)
        {
            string book_id = Bookid_edit_TBox.Text.ToString();
            string author_id = Authorid_edit_TBox.Text.ToString();
            string title = Title_edit_TBox.Text.ToString();
            string count = Count_edit_TBox.Text.ToString();
            string price = Price_edit_TBox.Text.ToString();
            string sql4 = $@"update books set author_id = {author_id}, title = N'{title}', Books_Count={count}, price={price} where books.id={book_id}";
            string СonnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(СonnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql4, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Book has been edited");
            }
            catch (Exception)
            {
                MessageBox.Show("ti ДАЛБАЕБ");
            }
            connection.Close();
        }

        private void Delete_book_Click(object sender, RoutedEventArgs e)
        {
            string book_id = Bookid_delete_TBox.Text.ToString();
            string sql5 = $@"DELETE FROM books WHERE books.id = {book_id}";
            string СonnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(СonnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql5, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Book has been deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("you entered something wrong");
            }
            connection.Close();
        }

        private void Delete_author_Click(object sender, RoutedEventArgs e)
        {
            string author_id = Author_delete_TBox.Text.ToString();
            string sql6 = $@"DELETE FROM authors WHERE authors.id = {author_id}";
            string СonnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(СonnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql6, connection);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Author has been deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("you entered something wrong");
            }
            connection.Close();
        }
    }
    
}
