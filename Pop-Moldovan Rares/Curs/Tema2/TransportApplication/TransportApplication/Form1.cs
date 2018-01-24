using System;
using System.Windows.Forms;
using TransportApplication.Interfete;

namespace TransportApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClient_Click_1(object sender, EventArgs e)
        {
            InterfataClient interfCl = new InterfataClient();
            interfCl.Show();
            //this.Hide();
        }

        private void btnAngajat_Click(object sender, EventArgs e)
        {
            InterfataTransportator interfTrans = new InterfataTransportator();
            interfTrans.Show();
            //this.Hide();
        }
    }
}
