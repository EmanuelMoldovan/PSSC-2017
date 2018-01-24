using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace LibraryRepository
{
    public class Library
    {
        private SqlConnection SqlConn = new SqlConnection();

        public Library()
        {
            SqlConn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Anda\\Documents\\LibraryDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConn.Open();
        }

        public void AddLibrary(LibraryModel.Library l)
        {
            using (SqlConn)
            {
                using(SqlDataAdapter SqlAdapter = new SqlDataAdapter("insert into Library values ('" + l.getName() + "','" + l.getCity() + "')", SqlConn))
                {
                    DataTable table = new DataTable();
                    SqlAdapter.Fill(table);
                }
            }
        }

        public List<string> listLibraries()
        {
            List<string> l = new List<string>();
            using (SqlConn)
            {
                using (SqlDataAdapter SqlAdapter = new SqlDataAdapter("select * from Library", SqlConn))
                {
                    DataTable table = new DataTable();
                    SqlAdapter.Fill(table);
                    for (int i = 0; i < table.Rows.Count; i++)
                        for (int j = 0; j < table.Columns.Count; j++)
                        {
                            l.Add(table.Rows[i].ItemArray[j].ToString());
                        }
                }
            }
            return l;
        }

        public void AddBook(LibraryModel.Book b)
        {
            using (SqlConn)
            {
                using (SqlDataAdapter SqlAdapter = new SqlDataAdapter("insert into Book values ('" + b.getTitle() + "','" + b.getAuthor() + "','" + b.getLibrary() + "')", SqlConn))
                {
                    DataTable table = new DataTable();
                    SqlAdapter.Fill(table);
                }
            }
        }

        public List<string> listBooks(string library)
        {
            List<string> list = new List<string>();
            using (SqlConn)
            {
                using (SqlDataAdapter SqlAdapter = new SqlDataAdapter("select * from Book where library = '" + library + "'", SqlConn))
                {
                    DataTable table = new DataTable();
                    SqlAdapter.Fill(table);
                    for (int i = 0; i < table.Rows.Count; i++)
                        for (int j = 0; j < table.Columns.Count; j++)
                        {
                            list.Add(table.Rows[i].ItemArray[j].ToString());
                        }
                }
            }
            return list;
        }

    }
}
