using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfataAngajat;
using InterfataClient;





namespace CVBibliotecaTema2PSSC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterfataClient.InterfataClient interfataClient = new InterfataClient.InterfataClient();
            interfataClient.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InterfataAngajat.InterfataAngajat interfataAngajat = new InterfataAngajat.InterfataAngajat();
            interfataAngajat.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
