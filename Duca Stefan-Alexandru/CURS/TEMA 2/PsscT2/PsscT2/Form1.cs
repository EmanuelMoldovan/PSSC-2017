using PsscT2.Modele.ModeleClienti;
using PsscT2.Modele.ModeleSalariati;
using PsscT2.Modele.ModeleSocietate;
using PsscT2.ModelGeneric;
using PsscT2.Repositories.SocietateRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsscT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cont cont_salariat1 = new Cont(10);
            Salariat salariat1 = new Salariat("salariat1",500,cont_salariat1);

           
            Cont cont_salariat2 = new Cont(10);
            Salariat salariat2 = new Salariat("salariat2", 650, cont_salariat1);

            Salariati salariati = new Salariati();

            salariati.AdaugaSalariat(salariat1);
            salariati.AdaugaSalariat(salariat2);


            Cont client1cont = new Cont(50);
            Client client1 = new Client("client1",client1cont);

            Cont client2cont = new Cont(50);
            Client client2 = new Client("client2", client2cont);

            Clienti clienti = new Clienti();
            clienti.AdaugaClient(client1);
            clienti.AdaugaClient(client2);

            MijlocFix mijloacefixe = new MijlocFix("sediu", 56656);
            CapitalPasiv capitalpasiv = new CapitalPasiv();
            capitalpasiv.AddMijlocFix(mijloacefixe);

            CapitalActiv capitalactiv = new CapitalActiv(46);


            Cont contsocietate = new Cont(8000);
            FactorySocietate factory = new FactorySocietate();
            Societate societate = factory.CreeazaSocietate("sac1", salariati.GetSalariati, clienti.GetClienti,  capitalactiv, capitalpasiv, contsocietate, 5);
            

            SocietateRepositories repo = new SocietateRepositories();
            repo.AdaugaSocietate(societate);


           
        }
    }
}
