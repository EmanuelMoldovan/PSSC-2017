using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace PSSC
{
    public partial class Restaurant : Form
    {
        public Restaurant()
        {
            InitializeComponent();
        }

        private void btn_add_food_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cmb_food.Text) && !string.IsNullOrEmpty(txt_x_food.Text))
            {
                dgv_food.Rows.Add();
                dgv_food.Rows[dgv_food.Rows.Count - 2].Cells[0].Value = cmb_food.Text;
                dgv_food.Rows[dgv_food.Rows.Count - 2].Cells[1].Value = txt_x_food.Text;
            }
        }

        private void btn_add_drinks_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmb_drinks.Text) && !string.IsNullOrEmpty(txt_x_drinks.Text))
            {
                dgv_drinks.Rows.Add();
                dgv_drinks.Rows[dgv_drinks.Rows.Count - 2].Cells[0].Value = cmb_drinks.Text;
                dgv_drinks.Rows[dgv_drinks.Rows.Count - 2].Cells[1].Value = txt_x_drinks.Text;
            }
        }

        private void btn_send_order_Click(object sender, EventArgs e)
        {
            
            log_box.Items.Add("Order sent by: " + cmb_waiter.Text+" "+ DateTime.Now.ToString("HH:mm:ss"));

            Variables._order_nr++;
            foreach(DataGridViewRow _dgvr_food in dgv_food.Rows)
            {
                try
                {
                    Food food = new Food(_dgvr_food.Cells[0].Value.ToString(),
                        _dgvr_food.Cells[1].Value.ToString(), Variables._order_nr);
                    MyLists._my_food_list.Add(food);
                }
                catch (Exception) {  }
            }

            foreach(DataGridViewRow _dgvr_drinks in dgv_drinks.Rows)
            {
                try
                {
                    Drinks drinks = new Drinks(_dgvr_drinks.Cells[0].Value.ToString(),
                        _dgvr_drinks.Cells[1].Value.ToString(), Variables._order_nr);
                    MyLists._my_drinks_list.Add(drinks);
                }
                catch (Exception) { }
            }

            Order order = new Order(cmb_waiter.Text, cmb_table.Text, Variables._order_nr);
            MyLists._my_orders_list.Add(order);
            Restaurant restaurant = null;
            restaurant = this;
            Functions functions = new Functions(restaurant,1);

        }

        private void btn_export_orders_Click(object sender, EventArgs e)
        {
            log_box.Items.Add("Exporting Orders. "+ DateTime.Now.ToString("HH:mm:ss"));
            _xml_export.Filter = "XML Files|*.xml";
            if (_xml_export.ShowDialog() == DialogResult.OK)
            {
                Restaurant restaurant = null;
                restaurant = this;
                Functions functions = new Functions(restaurant,1);
                XmlExport.Write_Xml(_xml_export.FileName);
            }
        }

        private void btn_view_orders_Click(object sender, EventArgs e)
        {
            log_box.Items.Add("Viewing Orders. "+ DateTime.Now.ToString("HH:mm:ss"));
                CheckOrders _check_orders = new CheckOrders();
                _check_orders.Show(); 
        }

        private void btn_clear_order_Click(object sender, EventArgs e)
        {
            log_box.Items.Add("Order cleared. "+ DateTime.Now.ToString("HH:mm:ss"));
            Restaurant restaurant = null;
            restaurant = this;
            Functions functions = new Functions(restaurant,1);
        }

        private void btn_html_transform_Click(object sender, EventArgs e)
        {
            log_box.Items.Add("Transforming xml to html. "+ DateTime.Now.ToString("HH:mm:ss"));
            XmlToHtml _xml_to_html = new XmlToHtml();
            _xml_to_html.Show();
        }

        private void btn_reset_orders_Click(object sender, EventArgs e)
        {
            log_box.Items.Add("All Orders are cleared. "+ DateTime.Now.ToString("HH:mm:ss"));
            Restaurant restaurant = null;
            restaurant = this;
            Functions functions = new Functions(restaurant, 2);
        }
    }
}
