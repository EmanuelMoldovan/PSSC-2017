using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Jucatori
{
    public class Jucatori
    {
        private String nume;
        private int varsta;
        private String post;
        private int nr_tricou;
        private String echipa;
        public Jucatori(String nume, int varsta, String post, int nr_tricou,String echipa)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.post = post;
            this.nr_tricou = nr_tricou;
            this.echipa = echipa;
        }
        public Jucatori()
        {

        }
        public String get_nume()
        {
            return nume;
        }
        public String get_post()
        {
            return post;
        }
        public int get_varsta()
        {
            return varsta;
        }
        public int get_nr_tricou()
        {
            return nr_tricou;
        }
        public string get_echipa()
        {
            return echipa;
        }
    }
}
