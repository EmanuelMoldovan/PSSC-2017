using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColectiiBiblioteca;
using Modele.Biblioteca.Entitati;


namespace ServiciiBiblioteca
{
    public class AdaugaClient
    {
        public static void Adauga_Client()
        {
            StocareClient.listaClienti.Add(new Client("Popescu", "Ion", "1234567891234", 4));
            StocareClient.listaClienti.Add(new Client("Popescu", "Marian", "1204567891234", 7));
            StocareClient.listaClienti.Add(new Client("Dumitrescu", "Gheorghe", "12345651591234", 10));
            StocareClient.listaClienti.Add(new Client("Gheorghe", "Cristian", "1234536291234", 3));
            StocareClient.listaClienti.Add(new Client("Andrei", "Marcel", "123411111234", 25));
            StocareClient.listaClienti.Add(new Client("Ionescu", "Ionel", "12345678944534", 7));
        }
    }
}
