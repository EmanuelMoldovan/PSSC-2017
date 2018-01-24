using System;
using System.Windows.Forms;
using TransportApplication.Modele.ValueObjects;
using TransportApplication.Repository;

namespace TransportApplication.Interfete
{
    public partial class InterfataBilete : Form
    {
        Pasager pas = new Pasager();
        Bilet bilet = new Bilet();

        public InterfataBilete()
        {
            InitializeComponent();
            
        }

        private void InterfataBilete_Load(object sender, EventArgs e)
        {

        }

        private void btnCautaRute_Click(object sender, EventArgs e)
        {
            Bilet bilet = new Bilet(TraseuDorit.traseuDorit.LOC_PLECARE, 
                TraseuDorit.traseuDorit.ORA_PLECARE,
                TraseuDorit.traseuDorit.LOC_SOSIRE,
                TraseuDorit.traseuDorit.ORA_SOSIRE);
          

            pas = new Pasager(tbNumePasager.Text);

            StoreBilet.listaBilete.Add(bilet);
            StorePasager.listaPasageri.Add(pas);

            lblBilet.Text += pas.ToString();
            lblBilet.Text += "\nLocalitate plecare: ";
            lblBilet.Text += bilet.BILET_PLECARE;
            lblBilet.Text += "\nOra plecare: ";
            lblBilet.Text += bilet.BILET_ORA_PLECARE;
            lblBilet.Text += "\nLocalitate sosire: ";
            lblBilet.Text += bilet.BILET_DESTINAITE;
            lblBilet.Text += "\nOra sosire: ";
            lblBilet.Text += bilet.BILET_ORA_SOSIRE;

        }

        private void btnSaveBilet_Click(object sender, EventArgs e)
        {
            if (tbNumePasager != null)
            {
                string path = @"Z:\Facultate\Tema2\TransportApplication\TransportApplication\Servicii\SeriviciiCilenti\FisierBilete.txt";
                using (System.IO.StreamWriter fisier = new System.IO.StreamWriter(path, true))
                {

                    fisier.WriteLine(pas.ToString());

                    fisier.WriteLine("Localitate plecare: " + TraseuDorit.traseuDorit.LOC_PLECARE
                        + " Ora plecare: " + TraseuDorit.traseuDorit.ORA_PLECARE);

                    fisier.WriteLine("Localitate sosire: " + TraseuDorit.traseuDorit.LOC_SOSIRE
                        + " Ora sosire: " + TraseuDorit.traseuDorit.ORA_SOSIRE);

                    MessageBox.Show("Biletul a fost salvat");
                    lblBilet.Text = null;

                }
            }
            else
            {
                MessageBox.Show("Introduce-ti numele si vizualizati biletul");
            }
            
                
        }


    }
}
