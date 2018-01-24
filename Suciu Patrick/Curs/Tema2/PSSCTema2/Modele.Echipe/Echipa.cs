using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Echipe
{
    public class Echipa
    {
        String tara;
        int an_infiintare;
        int nr_jucatori;
        String nume;
        List<Modele.Jucatori.Jucatori> jucatori_echipa = new List<Modele.Jucatori.Jucatori>();
        String culori;
        public Echipa()
        {

        }
        public Echipa(String tara, int an_infiintare, String culori,String nume)
        {
            this.tara = tara;
            this.an_infiintare = an_infiintare;
            this.culori = culori;
            this.nr_jucatori = 0;
            this.nume = nume;
        }
        public void add_jucator(Modele.Jucatori.Jucatori jucator)
        {
            jucatori_echipa.Add(jucator);
            nr_jucatori++;
        }
        public List<Modele.Jucatori.Jucatori> get_jucatori()
        {
            return jucatori_echipa;
        }
        public int get_nr_jucatori()
        {
            return nr_jucatori;
        }
        public int get_an_infiintare()
        {
            return an_infiintare;
        }
        public String get_culori()
        {
            return culori;
        }
        public String get_tara()
        {
            return tara;
        }
        public String get_nume()
        {
            return nume;
        }
    }
}
