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

namespace InterfataClient
{
    public partial class InterfataClient : Form
    {  
        public InterfataClient()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiciiBiblioteca.AdaugaCarte.adauga_carte();
            ServiciiBiblioteca.AdaugaClient.Adauga_Client();
            Carte result = StocareCarte.listaCarti.Find(x => x.Titlu1 == textBox1.Text);
            Client resultSecond = StocareClient.listaClienti.Find(y => y.Nume1 == textBoxNume.Text && y.Prenume1 == textBoxPrenume.Text);
            if(resultSecond==null)
            {
                MessageBox.Show("Nu sunteti in baza de date a bibliotecii!");
            }
            else
                if (result != null && resultSecond != null)
                {
                    MessageBox.Show("\nID Carte:" + result.IdCarte + "\nDomeniu:" + result.Domeniu1 + "\nAutor:"
                        + result.Autor1 + "\nTitlu:" + result.Titlu1 + "\nNumar exemplare:" + result.NrExemplare +
                        "\nTermen de retunare:" + result.TermenReturnare);
                }
                else
                    MessageBox.Show("Nu exista o carte cu acest nume.");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orar orar = new Orar("08:00-00:00", "10:00-16:00");
            MessageBox.Show("\nOrarul in timpul saptamanii este:" + orar.OrarInTimpulSapt1 +
                "\nOrarul la sfarsitul saptamnii este:" + orar.OrarLaSfSapt1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
