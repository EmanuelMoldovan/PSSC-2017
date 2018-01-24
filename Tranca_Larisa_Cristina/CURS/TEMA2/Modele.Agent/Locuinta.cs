using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele.Agent
{
    public class Locuinta
    {
        public PlainText AdresaLocuinta { get; private set; }
        public int NumarCamere { get; private set; }
        public int AnulConstructiei { get; private set; }
        public int numarulMaximDePersoane { get; private set; }
        public bool RecentRenovata;
        public bool esteRecentRenovata
        {
            get { return RecentRenovata; }
            set { this.RecentRenovata = (this.AnulConstructiei < 2017) ? true : false; }
        }
        public Locuinta(PlainText AdresaLocuinta, int NumarCamere, int AnulConstructie, int numarulMaximDePersoane)
        {
            numarulMaximDePersoane = numarulMaximDePersoane;
            AdresaLocuinta = AdresaLocuinta;
            NumarCamere = NumarCamere;
            AnulConstructie = AnulConstructie;
            numarulMaximDePersoane = numarulMaximDePersoane;
        }
    }
}
