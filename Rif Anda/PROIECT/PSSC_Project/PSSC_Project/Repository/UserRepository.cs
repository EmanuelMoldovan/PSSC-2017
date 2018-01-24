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
    class UserRepository
    {
        private SqlConnection SqlConn = new SqlConnection();

        public UserRepository()
        {
            SqlConn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\DBs\\Database.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConn.Open();
        }

        public List<string> listUsers()
        {
            List<string> l = new List<string>();
            using (SqlConn)
            {
                using (SqlDataAdapter SqlAdapter = new SqlDataAdapter("SELECT * FROM Users", SqlConn))
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
    }
}
