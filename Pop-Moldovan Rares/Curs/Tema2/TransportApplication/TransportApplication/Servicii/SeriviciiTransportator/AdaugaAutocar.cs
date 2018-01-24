using System;
using System.Collections.Generic;
using System.Linq;
using TransportApplication.Modele.Entitati;
using TransportApplication.Repository;

namespace TransportApplication.Servicii.SeriviciiTransportator
{
    public class AdaugaAutocar
    {

        public static void adauga_autocare()
        {
            StoreAutocar.listaAutocare.Add(new Autocar("Mercedes-Benz", "A233", "AR-91-CLG", "2004"));
            StoreAutocar.listaAutocare.Add(new Autocar("Mercedes-Benz", "A233", "CJ-91-CLG", "2014"));
            StoreAutocar.listaAutocare.Add(new Autocar("Mercedes-Benz", "A233", "TM-91-TRS", "2009"));

        }
    }
}
