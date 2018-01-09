using PSSC_Project.Repository;
using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public static string userId;
        UserRepository userRepo = new UserRepository();
        List<string> listUsers;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxUsers_Click(object sender, EventArgs e)
        {
            comboBoxUsers.Items.Clear();
            userRepo = new UserRepository();
            listUsers = userRepo.listUsers();
            for (int i = 0; i < listUsers.Count(); i += 3)
            {
                comboBoxUsers.Items.Add(listUsers.ElementAt(++i));
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string username = comboBoxUsers.Text;
            for (int i = 0; i < listUsers.Count(); i ++)
            {
                if (listUsers.ElementAt(i).Equals(username))
                    userId = listUsers.ElementAt(i-1);
            }
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}
