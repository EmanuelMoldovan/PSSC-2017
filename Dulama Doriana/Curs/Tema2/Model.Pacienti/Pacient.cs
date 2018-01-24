using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedData;

namespace Model.Pacienti
{
    public class Pacient
    {
        public static List<Pacient> listaPacienti = new List<Pacient>();
        //  public Dictionary<string, string> afectiuneRecomandare;
        public NameValueCollection afectiuneRecomandare;
        public int istoricExistent;

        public string cnp;
        public NumeIntreg numePacient;
        public string sex;
        public Data dataNastere;
        public Adresa adresa;
        public string ocupatie;
        public string locMunca;

        public int gasit = 0;

        public Pacient()
        {
            cnp = "";
            numePacient = new NumeIntreg("", "");
            sex = "";
            dataNastere = new Data(0, 0, 0);
            adresa = new Adresa("", "", "", 0);
            ocupatie = "";
            locMunca = "";
        }

        public Pacient(string cnp1,string n, string p, int zi, int luna, int an, string j, string l, string s, int nr, string o, string m)
        {
            cnp = cnp1;
            numePacient = new NumeIntreg(n, p);
            dataNastere = new Data(zi, luna, an);
            adresa = new Adresa(j, l, s, nr);
            ocupatie = o;
            locMunca = m;
           // afectiuneRecomandare = new Dictionary<string, string>();
           afectiuneRecomandare= new NameValueCollection();
            istoricExistent = 0;
        }
        public Pacient(string c,NumeIntreg n, string s,Data d, Adresa adr, string o, string l)
        {
            cnp = c;
            numePacient = n;
            dataNastere = d;
            sex = s;
            adresa = adr;
            ocupatie = o;
            locMunca = l;

            //afectiuneRecomandare = new Dictionary<string, string>();
            afectiuneRecomandare = new NameValueCollection();
        }

        public  Int32 CalculeazaVarsta()
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dataNastere.an * 100 + dataNastere.luna) * 100 + dataNastere.zi;

            return (a - b) / 10000;
        }

        public string toString()
        {
            return 
                "CNP: "+cnp + "\n" +
                "Nume intreg: " + numePacient.toString() + "\n" +
                "Data nastere: " + dataNastere.toString() + "\n" +
                "Adresa: " + adresa.toString() + "\n" +
                "Ocupatie: " + ocupatie + "\n" +
                "Loc de munca: " + locMunca;
        }

    }
}
