using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modele.Biblioteca.ObiecteValori;
using Modele.Biblioteca.Entitati;
using ColectiiBiblioteca;
using ServiciiBiblioteca;

namespace InterfataAngajat
{
    public partial class InterfataAngajat : Form
    {
        public InterfataAngajat()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiciiBiblioteca.AdaugaClient.Adauga_Client();
            Client result = StocareClient.listaClienti.Find(x => x.CNP1 == textBox6.Text);
            if (result != null)
            {
                MessageBox.Show("\nNume:"+result.Nume1+"\nPrenume:"+result.Prenume1+"\nCNP:"+result.CNP1
                    +"\nCarti Imprumutate:"+result.NrCartiImprumutate);
            }
            else
                MessageBox.Show("Nu exista un client cu acest CNP.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiciiBiblioteca.AdaugaCarte.adauga_carte();
            Carte result = StocareCarte.listaCarti.Find(x => x.IdCarte == textBox10.Text);
            if (result != null)
            {
                MessageBox.Show("\nID Carte:" + result.IdCarte + "\nDomeniu:" + result.Domeniu1 + "\nAutor:"
                    + result.Autor1 + "\nTitlu:" + result.Titlu1 + "\nNumar exemplare:" + result.NrExemplare +
                    "\nTermen de retunare:" + result.TermenReturnare);
            }
            else
                MessageBox.Show("Nu exista o carte cu acest ID.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carte carte = new Carte(textBoxDomeniu.Text, textBoxAutor.Text, textBoxTitlu.Text, textBoxId.Text,
                          Convert.ToInt32(textBoxExemplare.Text), textBoxTermen.Text);
            StocareCarte.listaCarti.Add(carte);
            MessageBox.Show("Adaugare realizata cu succes!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client(textBoxNume.Text, textBoxPrenume.Text, textBoxCNP.Text,
                Convert.ToInt32(numericUpDown1.Value));
            StocareClient.listaClienti.Add(client);
            MessageBox.Show("Adaugare realizata cu succes!");
        }
    }
}
