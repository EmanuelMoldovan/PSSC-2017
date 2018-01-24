using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Activitate;
using Modele.Generic;
using Modele.Organizator;
using Model.TabaraSportiva;
using Repositories.Activitate;
using Newtonsoft.Json;

namespace Tema2Pssc
{
    class Program
    {
    /*
     * Exemplu de utilizare a programului. Sunt adaugate prin cod cateva inregistari.
     * Pentru ca programul sa functioneze pentru cazuri reale este nevoie de o baza de date cu Taberisti si Echipe si Activitati
     * Este creeat un scenariu cu 2 activitati si sunt acordate puncte echipelor
     */
        static void Main(string[] args) 
        {
            var tabara = new TabaraSportiva();
            Organizator organizator1 = new Organizator(new TextNume("Tarce Paul"), 22, GradOrganizator.ResponsabilTabara);
            Organizator organizator2 = new Organizator(new TextNume("Tody Mickey"), 43, GradOrganizator.ResponsabilGrupMic);

            var activitate = ActivitateFactory.Instance.CreeazaActivitate(new TextNume("Shaolin Game"), 120, new Puncte(8));
            var activitate2 = ActivitateFactory.Instance.CreeazaActivitate(new TextNume("Tiki taka"), 50, new Puncte(4));
            var repository = new ActivitateRepository();
            repository.AdaugaActivitate(activitate);
            repository.AdaugaActivitate(activitate2);

           // List<Echipe>echipe = JsonConvert.DeserializeObject<List<Echipe>>(@"D:\cursuri\An4\PSSC\lab\Tema2\DDDTabara\DDDTabara\EchipeAndTaberisti.json");
            //ctivitate.adaugaEchipa(echipe[0]);

            //ADAUGARE DATE
            var taberist1 = new Taberist() { Id = new IdTaberist("0001"),puncte = new Puncte(0) };
            var taberist2 = new Taberist() { Id = new IdTaberist("0002"), puncte = new Puncte(3) };
            var taberist3 = new Taberist() { Id = new IdTaberist("0003"), puncte = new Puncte(4) };
            var taberist4 = new Taberist() { Id = new IdTaberist("0004"), puncte = new Puncte(1) };

            List<Taberist> listTaberisti1 = new List<Taberist>() { taberist1, taberist2 };
            List<Taberist> listTaberisti2 = new List<Taberist>() { taberist2, taberist3 };
            List<Taberist> listTaberisti3 = new List<Taberist>() { taberist4 };
            var echipa1 = new Echipe(new TextNume("Alpha"),listTaberisti1 );
            var echipa2 = new Echipe(new TextNume("Beta"), listTaberisti2);
            List<Echipe> listEchipe = new List<Echipe>() { echipa1, echipa2 };
            
            activitate.adaugaEchipe(listEchipe);  // 2 moduri de adaugare a echipelor;
            activitate2.adaugaEchipa(echipa1);
            activitate2.adaugaEchipa(echipa2);

            //DESFASURARE ACTIVITATI
            activitate.StartActivitate();
            activitate2.StartActivitate();

            //INCHEIERE ACTIVITATI
            activitate.StopActivitate();
            activitate2.StopActivitate();
            if (activitate.stareActivitate == StareActivitate.Incheiata && activitate2.stareActivitate == StareActivitate.Incheiata)
            {
                //ACTIVITATE1
                echipa1.Punctaj.Add(activitate.PunctajCastigator); //echipa castigatoare activitate1
                echipa2.Punctaj.Add(new Puncte(0)); // echipa pierzatoare

                //ACTIVITATE2
                echipa1.Punctaj.Add(new Puncte((activitate2.PunctajCastigator.Valoare)/2));
                echipa2.Punctaj.Add(new Puncte((activitate2.PunctajCastigator.Valoare) / 2));
            }

            organizator1.getFeedback(taberist1.sendFeedback());  //testez ce returneaza 
            organizator2.getFeedback(taberist2.sendFeedback());  
        }
    }
}
