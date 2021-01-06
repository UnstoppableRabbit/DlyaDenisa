namespace LibraryAdminApp
{
    public class ConnectionClass
    {
        public static string sql1 = @"SELECT title, authors.fullname, author_id, Books_Count, price, books.id
                                      FROM books join authors on(authors.id=author_id)";

    }
}
