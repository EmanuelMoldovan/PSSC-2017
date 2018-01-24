using PsscT2.Modele.ModeleSocietate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsscT2.Repositories.SocietateRepositories
{
   
    class SocietateRepositories
    {
        private List<Modele.ModeleSocietate.Societate> societati = new List<Modele.ModeleSocietate.Societate>();


      

        public void AdaugaSocietate(Societate societate)
        {
            if (!societati.Contains(societate))
            {
                societati.Add(societate);
            }
            else
            {
                MessageBox.Show("exista societatea");
            }

        }

    }
}
