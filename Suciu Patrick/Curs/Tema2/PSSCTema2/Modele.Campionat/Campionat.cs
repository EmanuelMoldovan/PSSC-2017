using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Campionat
{
    public class Campionat
    {
        String nume;
        int nr_echipe;
        public Campionat(String nume,int nr_echipe)
        {
            this.nume = nume;
            this.nr_echipe = nr_echipe;
        }
        public String get_nume()
        {
            return nume;
        }
        public int get_nr_echipe()
        {
            return nr_echipe;
        }
    }
}
