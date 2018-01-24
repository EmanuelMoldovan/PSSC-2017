using TransportApplication.Repository;
using TransportApplication.Modele.Entitati;

namespace TransportApplication.Servicii.SeriviciiTransportator
{
    public class AdaugaTraseu
    {
        public static void adauga_trasee()
        {
            StoreTrasee.listaTrasee.Add(new Traseu("Arad","Timisoara","10:00","11:00"));
            StoreTrasee.listaTrasee.Add(new Traseu("Timisoara", "Arad", "11:00", "12:00"));
            StoreTrasee.listaTrasee.Add(new Traseu("Arad", "Timisoara", "12:00", "13:00"));
            StoreTrasee.listaTrasee.Add(new Traseu("Arad", "Oradea", "09:00", "11:00"));
            StoreTrasee.listaTrasee.Add(new Traseu("Cluj", "Timisoara", "14:00", "18:00"));
            StoreTrasee.listaTrasee.Add(new Traseu("Bucuresti", "Timisoara", "08:00", "20:00"));
            StoreTrasee.listaTrasee.Add(new Traseu("Lugoj", "Arad", "11:00", "13:00"));
            StoreTrasee.listaTrasee.Add(new Traseu("Oradea", "Bucuresti", "8:00", "20:00"));
            StoreTrasee.listaTrasee.Add(new Traseu("Targu Mures", "Arad", "9:00", "14:00"));

        }
    }
}
