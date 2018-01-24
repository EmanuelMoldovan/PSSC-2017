using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace PSSC_Project.Repository
{
    class ProductRepository
    {
        private SqlConnection SqlConn = new SqlConnection();

        public ProductRepository()
        {
            SqlConn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\DBs\\Database.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConn.Open();
        }

        public List<string> listProducts()
        {
            List<string> l = new List<string>();
            using (SqlConn)
            {
                using (SqlDataAdapter SqlAdapter = new SqlDataAdapter("select * from Product", SqlConn))
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

        public List<string> listProductsByPickup(string pickup, string user)
        {
            List<string> l = new List<string>();
            using (SqlConn)
            {
                using (SqlDataAdapter SqlAdapter = new SqlDataAdapter("select id, name, price, quantity from Product where id_pickup=" + pickup + " and id_user=" + user, SqlConn))
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

        public List<string> listProductsByUser(string user)
        {
            List<string> l = new List<string>();
            using (SqlConn)
            {
                using (SqlDataAdapter SqlAdapter = new SqlDataAdapter("select id, name, price, quantity from Product where id_user=" + user, SqlConn))
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

        public void insertProduct(int id, int price, string name, int quantity, int iduser, int idpick)
        {
            using (SqlConn)
                {
                using (SqlDataAdapter SqlAdapter = new SqlDataAdapter("insert into Product values ('" + id + "','" + price + "','" + name + "','" + quantity + "','" + iduser + "','" + idpick + "')", SqlConn)) 
                    {
                        DataTable table = new DataTable();
                        SqlAdapter.Fill(table);
                    }
                }
        }

    }
}
