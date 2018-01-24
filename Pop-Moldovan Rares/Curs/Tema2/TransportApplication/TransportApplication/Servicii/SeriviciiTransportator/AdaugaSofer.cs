using System.Collections.Generic;
using System.Linq;
using TransportApplication.Modele.Entitati;
using TransportApplication.Repository;

namespace TransportApplication.Servicii.SeriviciiTransportator
{
    public class AdaugaSofer
    {
        public static void adauga_sofer()
        {
            StoreSofer.listaSoferi.Add(new Sofer("Ioan Mihalache", "1652332442", 56));
            StoreSofer.listaSoferi.Add(new Sofer("Igor Petrov", "1702332442", 46));
            StoreSofer.listaSoferi.Add(new Sofer("Jan Mihai", "19742332442", 42));
            StoreSofer.listaSoferi.Add(new Sofer("Cristian Popescu", "1792332442", 36));
        }
    }
}
