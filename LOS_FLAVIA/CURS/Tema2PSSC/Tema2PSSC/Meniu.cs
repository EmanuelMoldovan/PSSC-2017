using Modele.Ambulanta;
using Modele.Angajat;
using Modele.Investigatie;
using Modele.Medicament;
using Modele.Pacient;
using Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2PSSC
{
   public class Meniu
    {
       public void afisareMeniu()
        {
            Console.Write("1.Afisati toate ambulantele.\n");
            Console.Write("2.Afisati toti angajatii.\n");
            Console.Write("3.Afisati analizele pacientului cu CNP-ul:\n");
            Console.Write("4.Afisati stocul de medicamente.\n");
            Console.Write("5.Afisati toti pacientii.\n");
            Console.Write("6.Generati fisa externare pt pacientul cu CNP-ul:\n");
        }
        public void selectareOptiune(int x, Pacienti pacienti, Ambulante ambulante, Angajati angajati,Medicamente medicamente,List<Investigatie> investigatii)
        {
            switch (x)
            {
                case 0: break;
                case 1:
                    Console.Write(ambulante.ToString());
                    Console.Write("\n\n");
                    break;
                case 2:
                    Console.Write(angajati.ToString());
                    Console.Write("\n\n");
                    break;
                case 3: Console.Write("Dati CNP:\n");
                    string cnp = Console.ReadLine();
                    foreach(var inv in investigatii)
                    {
                        if(inv.Cnp.Equals(cnp))
                        {
                            Console.Write( inv.ToString());
                        }
                    }
                    break;
                case 4:
                    Console.Write(medicamente.ToString());
                    Console.Write("\n\n");
                    break;
                case 5:
                    Console.Write(pacienti.ToString());
                    Console.Write("\n\n");
                    break;
                case 6:
                    List<string> content = new List<string>();
                    GeneratorRapoartePdf pdf = new GeneratorRapoartePdf();
                    Console.Write("Dati CNP:\n");
                    string cnp2 = Console.ReadLine();
                    foreach(Pacient pac in pacienti._pacienti)
                    {
                        if(pac.Cnp == cnp2)
                        {
                            content.Add(pac.ToString());
                        }
                    }
                    foreach (var inv in investigatii)
                    {
                        if (inv.Cnp.Equals(cnp2))
                        {
                            content.Add(inv.ToString());
                        }
                    }
                    pdf.GenerareRaportTabelar(cnp2+".pdf", content);


                    break;
            }

        }
    }
}
