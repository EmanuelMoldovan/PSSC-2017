using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSC
{
    public partial class CheckOrders : Form
    {
        public CheckOrders()
        {
            InitializeComponent();
        }

        private void btn_check_orders_Click(object sender, EventArgs e)
        {
            dgv_orders.Rows.Clear();
            string _waiter = cmb_waiter.Text;
            foreach (GetXmlData _data in MyLists._my_XmlData_list)
            {
                if(_waiter ==_data._waiter)
                {
                    dgv_orders.Rows.Add();
                    dgv_orders.Rows[dgv_orders.Rows.Count - 1].Cells[0].Value = _data._order_no;
                    dgv_orders.Rows[dgv_orders.Rows.Count - 1].Cells[1].Value = _data._table;
                    dgv_orders.Rows[dgv_orders.Rows.Count - 1].Cells[2].Value = _data._order;
                    dgv_orders.Rows[dgv_orders.Rows.Count - 1].Cells[3].Value = _data._amount;
                }
            }
        }

        private void btn_import_data_Click(object sender, EventArgs e)
        {
            _xml_import.Filter = "XML Files|*.xml";
            if (_xml_import.ShowDialog() == DialogResult.OK)
            {
                MyLists._my_XmlData_list.Clear();
                XmlImport.Read_Xml(_xml_import.FileName);
                btn_check_orders.Enabled = true;
                btn_check_orders.BackColor = Color.LightSeaGreen;
            }
        }
    }
}
