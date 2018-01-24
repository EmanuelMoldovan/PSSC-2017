using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColectiiBiblioteca;
using Modele.Biblioteca.Entitati;

namespace ServiciiBiblioteca
{
    public class AdaugaCarte
    {
        public static void adauga_carte()
        {
            StocareCarte.listaCarti.Add(new Carte("literatura", "Autor1", "Titlu1", "1", 15, "3 zile"));
            StocareCarte.listaCarti.Add(new Carte("algebra", "Autor13", "Titlu100", "2", 25, "25 zile"));
            StocareCarte.listaCarti.Add(new Carte("analiza matematica", "Autor1", "Titlu5151", "3", 14, "7 zile"));
            StocareCarte.listaCarti.Add(new Carte("literatura", "Autor1", "Titlu13", "4", 255, "3 zile"));
            StocareCarte.listaCarti.Add(new Carte("programare", "Autor12", "Titlu12", "5", 15, "30 zile"));
            StocareCarte.listaCarti.Add(new Carte("literatura", "Autor12", "Titlu251", "6", 256, "28 zile"));
            StocareCarte.listaCarti.Add(new Carte("electrica", "Autor1", "Titlu11", "07", 100, "30 zile"));
            StocareCarte.listaCarti.Add(new Carte("fizica", "Autor1", "Titlu144", "008", 45, "7 zile"));
            StocareCarte.listaCarti.Add(new Carte("electronica", "Autor10", "Titlu14", "0001", 98, "3 zile"));
        }
    }
}
