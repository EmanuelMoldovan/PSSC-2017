using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColectiiBiblioteca;
using Modele.Biblioteca.Entitati;


namespace ServiciiBiblioteca
{
    public class AdaugaAngajat
    {
        public static void adauga_angajat()
        {
            StocareAngajat.listaAngajati.Add(new Angajat("0100000000", "Ionescu", "Ion", "bibliotecar"));
            StocareAngajat.listaAngajati.Add(new Angajat("0100008280", "Popescu", "Andrei", "sef-bibliotecar"));
            StocareAngajat.listaAngajati.Add(new Angajat("0105500000", "Popescu", "Marcel", "Administrator"));
            StocareAngajat.listaAngajati.Add(new Angajat("0102544000", "Dumitrescu", "Ion", "bibliotecar"));
            StocareAngajat.listaAngajati.Add(new Angajat("0102544020", "Albescu", "Ion", "bibliotecar"));
            StocareAngajat.listaAngajati.Add(new Angajat("0102541500", "Dumitrescu", "Vasile", "portar"));
        }
    }
}
