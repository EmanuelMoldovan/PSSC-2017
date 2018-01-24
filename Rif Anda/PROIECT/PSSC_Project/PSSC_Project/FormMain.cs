using PSSC_Project.Repository;
using PSSC_Project.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSC_Project
{
    public partial class FormMain : Form
    {
        PickupRepository pickupRepo = new PickupRepository();
        ProductRepository productRepo = new ProductRepository();
        ProductService prodServ = new ProductService();
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            tableProducts.Controls.Clear();
            pickupRepo = new PickupRepository();
            productRepo = new ProductRepository();
            List<string> listPick = new List<string>();
            string option = comboBoxLocations.Text;
            if (option.Equals("all"))
            {
                listPick = productRepo.listProductsByUser(Form1.userId);
            }
            else
            {
                List<string> listPickups = pickupRepo.listPickups();
                for (int i = 0; i < listPickups.Count(); i++)
                {
                    if (listPickups.ElementAt(i).Equals(option))
                        listPick = productRepo.listProductsByPickup(listPickups.ElementAt(i-1), Form1.userId);
                }
            }
            int col = 0;
            int row = 1;
            for (int i = 0; i < listPick.Count(); i++)
            {
                TextBox t = new TextBox();
                t.Text = listPick.ElementAt(i);
                tableProducts.RowStyles.Insert(tableProducts.RowCount, new RowStyle(SizeType.AutoSize));
                tableProducts.Controls.Add(t, col, row);
                col++;
                if (col == 4)
                {
                    col = 0;
                    row++;
                }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            pickupRepo = new PickupRepository();
            comboBoxLocations.Items.Clear();
            comboBoxLocations.Items.Add("all");
            List<string> listPickups = pickupRepo.listPickups();
            for (int i = 0; i < listPickups.Count(); i+=3)
                comboBoxLocations.Items.Add(listPickups.ElementAt(++i));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            pickupRepo = new PickupRepository();
            productRepo = new ProductRepository();
            string idpick = "default";
            string option = comboBoxLocations.Text;
            List<string> listPickups = pickupRepo.listPickups();
            for (int i = 0; i < listPickups.Count(); i++)
            {
                if (listPickups.ElementAt(i).Equals(option))
                    idpick = listPickups.ElementAt(i - 1);
            }
            prodServ.addProduct(textBoxId.Text,textBoxName.Text, textBoxPrice.Text, textBoxQuantity.Text, Form1.userId, idpick);
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
        }
    }
}
