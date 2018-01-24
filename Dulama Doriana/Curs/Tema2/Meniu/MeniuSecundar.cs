using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Pacienti;
using SharedData;

namespace Meniu
{
    public class MeniuSecundar
    {
        public string MeniuFisaPersonala()
        {
            Console.WriteLine("Dati cnp-ul pacientului cautat");
            var cnp = Console.ReadLine();
            return cnp;
        }

        public string MeniuGenerareDocumente()
        {
            Console.WriteLine("\nAlegeti tipul de document dorit:");
            Console.WriteLine("\n1.Adeverinta Medicala");
            Console.WriteLine("\n2.Reteta");
            var optiune = Console.ReadLine();

            return optiune;
        }

        public Pacient MeniuAdaugarePacient()
        {
            Console.WriteLine("Dati cnp pacient: "); var cnp = Console.ReadLine();
            Console.WriteLine("Dati numele pacientului: "); var nume = Console.ReadLine();
            Console.WriteLine("Dati prenumele pacientului: "); var prenume = Console.ReadLine();
            var numePacient = new NumeIntreg(nume, prenume);
            Console.WriteLine("Dati sexul pacientului (M/F) : "); var sex = Console.ReadLine();
            Console.WriteLine("Dati ziua de nastere: "); var zi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Dati luna nasterii: "); var luna = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Dati anul nasterii: "); var an = Convert.ToInt16(Console.ReadLine());
            var dataNastere = new Data(zi, luna, an);

            Console.WriteLine("Dati judet pacient: "); var judet = Console.ReadLine();
            Console.WriteLine("Dati localitate pacient: "); var localitate = Console.ReadLine();
            Console.WriteLine("Dati strada pacient: "); var strada = Console.ReadLine();
            Console.WriteLine("Dati nr Strada pacient: "); var nrStrada = Convert.ToInt16(Console.ReadLine());
            var adresa = new Adresa(judet, localitate, strada, nrStrada);

            Console.WriteLine("Dati ocupatia pacient: "); var ocupatie = Console.ReadLine();
            Console.WriteLine("Dati loc munca pacient: "); var locMunca = Console.ReadLine();

            var pacient = new Pacient(cnp, numePacient, sex, dataNastere, adresa, ocupatie, locMunca);
            return pacient;
        }
    }
}
