using System;
using System.Diagnostics;
using System.Windows.Forms;
using TransportApplication.Modele.Entitati;
using TransportApplication.Repository;

namespace TransportApplication.Interfete
{
    public partial class InterfataTransportator : Form
    {
        public InterfataTransportator()
        {
            InitializeComponent();
        }

        private void btnAdaugaAutocar_Click(object sender, EventArgs e)
        {
            //Service adauga atocar

            try
            {
                StoreAutocar.listaAutocare.Add(new Autocar(textBox1.Text, textBox2.Text, textBox3.Text, 
                    textBox4.Text));
                sterge_continut_textBox();
            }
            catch (System.ArgumentNullException er)
            {
                er = new ArgumentNullException("Nu ati introdus toate datele");
            }

            foreach (Autocar item in StoreAutocar.listaAutocare)
            {
                MessageBox.Show("Ati introdus: " + item.ToString());
            }
        }

        private void btnAdaugaSofer_Click(object sender, EventArgs e)
        {
            //Service adauga sofer

            try
            {
                StoreSofer.listaSoferi.Add(new Sofer(textBox5.Text, textBox6.Text, int.Parse(textBox7.Text)));
                sterge_continut_textBox();
            }
            catch (System.ArgumentNullException er)
            {
                er = new ArgumentNullException("Nu ati introdus toate datele");
            }
            foreach (Sofer sof in StoreSofer.listaSoferi)
            MessageBox.Show("Ati introdus: " + sof.ToString());
        }

        private void InterfataTransportator_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddTraseu_Click(object sender, EventArgs e)
        {
            try
            {
                StoreTrasee.listaTrasee.Add(new Traseu(tbLocPl.Text, tbLocS.Text, tbOPl.Text,tbOS.Text));
                sterge_continut_textBox();
            }
            catch (System.ArgumentNullException er)
            {
                er = new ArgumentNullException("Nu ati introdus toate datele");
            }
            foreach (Traseu tras in StoreTrasee.listaTrasee)
                MessageBox.Show("Ati introdus: " + tras.ToString());
        }

        private void sterge_continut_textBox()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            tbLocPl.Text = null;
            tbLocS.Text = null;
            tbOPl.Text = null;
            tbOS.Text = null;
        }

        private void btnVizualizareBilete_Click(object sender, EventArgs e)
        {
            String path = @"Z:\Facultate\Tema2\TransportApplication\TransportApplication\Servicii\SeriviciiCilenti\FisierBilete.txt";
            Process.Start("notepad", path);
        }
    }
    
}
