using System;
using System.Windows.Forms;
using TransportApplication.Modele.Entitati;
using TransportApplication.Repository;
using TransportApplication.Servicii.SeriviciiTransportator;
using TransportApplication.Modele.ValueObjects;

namespace TransportApplication.Interfete
{
    public partial class InterfataClient : Form
    {
        int contor = 0;

        public InterfataClient()
        {
            InitializeComponent();
            
            label4.Text = "Orasul de plecare trebuie sa fie diferit de cel destinatie!";
            label4.Visible = false;

            //incarcare autocare in lista
            AdaugaAutocar.adauga_autocare();

            //incarcare trasee in lista
            AdaugaTraseu.adauga_trasee();

        }

        private void btnCautaRute_Click(object sender, EventArgs e)
        {
            bool ver = false;

            if (comboBox1.SelectedItem.Equals(comboBoxOrase.SelectedItem))
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }

            foreach(Traseu tras in StoreTrasee.listaTrasee)
            {
                if(comboBox1.Text.Equals(tras.LOC_PLECARE) &&
                    comboBoxOrase.Text.Equals(tras.LOC_SOSIRE))
                {
                    listTrasee.Items.Add(tras);
                    ver = true;
                    label4.Visible = false;

                    TraseuDorit.traseuDorit = new Traseu(tras.LOC_PLECARE, tras.LOC_SOSIRE, tras.ORA_PLECARE, tras.ORA_SOSIRE);
                    
                }

                else  if( ver == false )
                {
                    label4.Visible = true;
                    label4.Text = "Nu exita traseu pentru ruta dorita";
                    listTrasee.Items.Clear();
                }
            }
            
            
        }  

        private void InterfataClient_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAfiseazaTot_Click(object sender, EventArgs e)
        {
            
           
            if (contor == 0)
            {
                foreach (Traseu tras in StoreTrasee.listaTrasee)
                {
                    listTrasee.Items.Add(tras);
                }
               
            }
            contor++;

        }

        private void listTrasee_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Traseu tras in StoreTrasee.listaTrasee)
            {
                if (listTrasee.SelectedItem.Equals(tras))
                {
                    TraseuDorit.traseuDorit = new Traseu(tras.LOC_PLECARE, tras.LOC_SOSIRE, tras.ORA_PLECARE, tras.ORA_SOSIRE);
                }
            }
            InterfataBilete interfB = new InterfataBilete();
            interfB.Show();

            
        }
    }
}
