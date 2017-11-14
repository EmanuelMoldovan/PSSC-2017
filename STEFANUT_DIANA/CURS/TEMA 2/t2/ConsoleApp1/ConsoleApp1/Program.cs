using Modele.ClasaStudiu;
using Modele.Generic;
using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var clasaStudiu = ClasaStudiuFactory.Instance.CreeazaClasaStudiu("clasa 5A");
            Elev elev = new Elev(new NumarMatricol("ab12345"), new PlainText("Andrei"), new Nota(5), "biologie");
            clasaStudiu.InscrieNotaElev(elev);
            
        }
    }
}
