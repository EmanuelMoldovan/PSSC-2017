using Modele.Generic;
using Modele.Evenimente;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Modele.Agent
{
    class Cumparator
    {
        private readonly List<Eveniment> events = new List<Eveniment>();
        public ReadOnlyCollection<Eveniment> EvenimenteNoi
        {
            get
            {
                return events.AsReadOnly();
            }
        }
        public PlainText NumeCumparator { get; set; }
        public PlainText PrenumeCumparator { get; set; }
        public Email AdresaEmail { get; set; }
        public Telefon NumarTelefon { get; set; }

        public event EventHandler<Eveniment> Eveniment;
        public Cumparator(CumparatorDTO cumparatorDTO)
        {
            NumeCumparator = cumparatorDTO.NumeCumparator;
            PrenumeCumparator = cumparatorDTO.PrenumeCumparator;
            AdresaEmail = cumparatorDTO.AdresaEmail;
            NumarTelefon = cumparatorDTO.NumarTelefon;
            PublicaEveniment(new EvenimentGeneric<CumparatorDTO>(cumparatorDTO));
        }
        protected void PublicaEveniment(Eveniment eveniment)
        {
            events.Add(eveniment);
           if (Eveniment != null)
            {
                Eveniment(this, eveniment);
           }
        }
    }
}
