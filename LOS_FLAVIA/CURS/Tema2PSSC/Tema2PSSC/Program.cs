using System;
using System.Collections.Generic;
using Modele.Pacient;
using Modele.Ambulanta;
using Modele.Angajat;
using Modele.Medicament;
using Modele.Investigatie;

namespace Tema2PSSC
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int x;
            Meniu meniu = new Meniu();

            List<Pacient> listaPacienti = new List<Pacient>();
            listaPacienti.Add(new Pacient("2950622350067", "Popescu", "Ion", new Modele.Generic.Adresa("Timis", "Timisoara", "Salciei", 3), "preinfarct", new Modele.Generic.Data(6, 12, 2017)));
            listaPacienti.Add(new Pacient("2953475350067", "Ionescu", "Andreea", new Modele.Generic.Adresa("Timis", "Timisoara", "Plopi", 9), "ulcer", new Modele.Generic.Data(6, 8, 2017)));
            listaPacienti.Add(new Pacient("2950622763467", "Anghel", "Maria", new Modele.Generic.Adresa("Timis", "Timisoara", "Madrid", 10), "gripa", new Modele.Generic.Data(6, 7, 2017)));
            Pacienti lista = new Pacienti(listaPacienti);
           

            List<Ambulanta> listaAmbulante = new List<Ambulanta>();
            listaAmbulante.Add(new Ambulanta("VW", 2005, new Modele.Generic.NumarMasina("TM02WOW")));
            listaAmbulante.Add(new Ambulanta("Mercedes", 2000, new Modele.Generic.NumarMasina("TM02FXR")));
            listaAmbulante.Add(new Ambulanta("BMW", 2010, new Modele.Generic.NumarMasina("TM05PLS")));
            Ambulante listaAmb = new Ambulante(listaAmbulante);

            List<Angajat> listaAngajati = new List<Angajat>();
            listaAngajati.Add(new Angajat("29567342688","Pop","Ionel",new Modele.Generic.Adresa("Timis","Timisoara","Plop",3),"manager","Ionescu Maria"));
            listaAngajati.Add(new Angajat("29556742688", "Popovici", "Arthur", new Modele.Generic.Adresa("Timis", "Timisoara", "Sever Bocu", 20), "doctor", "Pop Ionel"));
            listaAngajati.Add(new Angajat("29567342688", "Meda", "Ana", new Modele.Generic.Adresa("Timis", "Timisoara", "Linitei", 3), "asistent", "Popovici Arthur"));
            Angajati listaAng = new Angajati(listaAngajati);

            List<Medicament> listaMedicamente = new List<Medicament>();
            listaMedicamente.Add(new Medicament(new Modele.Medicament.Furnizor("SC MED",new Modele.Generic.Adresa("Timis","Timisoara","Lazar",2)),"Algocalmin",200));
            listaMedicamente.Add(new Medicament(new Modele.Medicament.Furnizor("SC OSM", new Modele.Generic.Adresa("Timis", "Timisoara", "Maur", 23)), "Diazepam", 240));
            Medicamente listaMed = new Medicamente(listaMedicamente);

            List<Investigatie> investigatii = new List<Investigatie>();
            investigatii.Add(new Investigatie("2950622350067", new Analize(200, 100, 50)));
            investigatii.Add(new Investigatie("2953475350067", new Analize(300, 50, 20)));

            do
            {
               meniu.afisareMeniu();
                x = int.Parse(Console.ReadLine());
               meniu.selectareOptiune(x, lista,listaAmb, listaAng,listaMed,investigatii);

            } while (x != 0);
            Console.ReadLine();
        }
    }
}
