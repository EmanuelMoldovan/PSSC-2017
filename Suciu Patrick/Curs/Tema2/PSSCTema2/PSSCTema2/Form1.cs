using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modele.Jucatori;
using Repositories.Jucatori;
using Modele.Echipe;
using Repositories.Echipe;
using AfisareEchipe.Properties;

namespace PSSCTema2
{
    public partial class Form1 : Form
    {
        JucatoriRepository jucatori = new JucatoriRepository();
        EchipeRepository echipe = new EchipeRepository();
        Jucatori jucatorrep=new Jucatori();
        Echipa echipa = new Echipa();
        private static List<Modele.Echipe.Echipa> lista_echipe = new List<Modele.Echipe.Echipa>();
        private static List<Modele.Jucatori.Jucatori> lista_jucatori = new List<Modele.Jucatori.Jucatori>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonJucator_Click(object sender, EventArgs e)
        {
            if (textBoxNume.Text.ToString() != null  || textBoxPost.Text.ToString() != null ||
                textBoxVarsta.Text.ToString() != null || textBoxNumar.Text.ToString() != null ||textBoxEchipa.Text.ToString()!=null)
            {
                Jucatori jucator = new Jucatori(textBoxNume.Text.ToString(),
                    int.Parse(textBoxVarsta.Text.ToString()), textBoxPost.Text.ToString(),
                    int.Parse(textBoxNumar.Text.ToString()), textBoxEchipa.Text.ToString());
                jucatori.AdaugaJucator(jucator);

                echipa = echipe.GasesteEchipa(textBoxEchipa.Text.ToString());
                if (echipa != null)
                {
                    echipa.add_jucator(jucator);
                    MessageBox.Show("Jucatorul a fost adaugat in echipa");
                }
                else
                    MessageBox.Show("Jucatorul nu a fost adaugat in echipa");
                
            }

            else
                MessageBox.Show("Nu ati completat toate campurile");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEchipa_Click(object sender, EventArgs e)
        {
            if (textBoxCampionat.Text.ToString() != null || textBoxAn.Text.ToString()!=null
                || textBoxCulori.Text.ToString()!=null || textBoxNume_echipa.Text.ToString()!=null)
          
            {
                Echipa echipa2 = new Echipa(textBoxCampionat.Text.ToString(), int.Parse(textBoxAn.Text.ToString()),
                    textBoxCulori.Text.ToString(), textBoxNume_echipa.Text.ToString());

                echipe.AdaugaEchipa(echipa2);
              
                MessageBox.Show("Echipa a fost adaugata");
            }

            else
                MessageBox.Show("Nu ati completat toate campurile");
        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {

            lista_jucatori = jucatori.get_jucatori();
            AfisareJucatori.Jucatori_Notepad jucatori_total = new AfisareJucatori.Jucatori_Notepad();
            jucatori_total.Afisare(lista_jucatori);
           
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {

        }

        private void buttonEchipe_Click(object sender, EventArgs e)
        {
            lista_echipe = echipe.get_Echipe();
            AfisareEchipe.Echipe_Notepad echipa=new AfisareEchipe.Echipe_Notepad();
            echipa.Afisare(lista_echipe);


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stergere = echipe.RemoveEchipa(textBoxDeleteEchipa.Text.ToString(),jucatori);
            if (stergere == 1)
                MessageBox.Show("Echipa a fost stearsa");
            else
                MessageBox.Show("Echipa nu a fost gasita");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            echipa = echipe.GasesteEchipa(textBoxCautareEchipa.Text.ToString());
            if (echipa != null)
            {
                textBoxCampionat.Text = echipa.get_tara().ToString();
                textBoxAn.Text = echipa.get_an_infiintare().ToString();
                textBoxCulori.Text = echipa.get_culori().ToString();
                textBoxNume_echipa.Text = echipa.get_nume().ToString();
                MessageBox.Show("Echipa a fost gasita");
            }
            else
                MessageBox.Show("Echipa nu a fost gasita");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int stergere = jucatori.RemoveJucator(textBoxDeleteJucator.Text.ToString());
            if (stergere == 1)
                MessageBox.Show("Jucatorul a fost sters");
            else
                MessageBox.Show("Jucatorul nu a fost gasit");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jucatorrep = jucatori.FindJucator(textBoxCautareJucator.Text.ToString());
            if (echipa != null)
            {
                textBoxNume.Text = jucatorrep.get_nume().ToString();
                textBoxVarsta.Text = jucatorrep.get_varsta().ToString();
                textBoxPost.Text = jucatorrep.get_post().ToString();
                textBoxNumar.Text = jucatorrep.get_nr_tricou().ToString();
                textBoxEchipa.Text = jucatorrep.get_echipa().ToString();
                MessageBox.Show("Jucatorul a fost gasit");
            }
            else
                MessageBox.Show("Jucatorul nu a fost gasit");
        }
    }
}
