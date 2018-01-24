using Modele.Generic;
using Modele.Agent;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Modele.Agent
{
    class Vanzator
    {
        private readonly List<Eveniment> events = new List<Eveniment>();
        public ReadOnlyCollection<Eveniment> EvenimenteNoi
        {
            get
            {
                return events.AsReadOnly();
            }
        }
        public PlainText NumeVanzator { get; set; }
        public PlainText PrenumeVanzator { get; set; }
        public Email AdresaEmail { get; set; }
        public Telefon NumarTelefon { get; set; }
        public Locuinta AdresaLocuinta { get; set; }
        public StareLocuinta stareLocuinta { get; set; }

        public event EventHandler<Eveniment> Eveniment;
        public Vanzator(VanzatorDTO vanzatorDTO)
        {
            NumeVanzator = vanzatorDTO.NumeVanzator;
            PrenumeVanzator = vanzatorDTO.PrenumeVanzator;
            AdresaEmail = vanzatorDTO.AdresaEmail;
            NumarTelefon = vanzatorDTO.NumarTelefon;
            AdresaLocuinta = vanzatorDTO.AdresaLocuinta;
            stareLocuinta = vanzatorDTO.stareLocuinta;
            PublicaEveniment(new EvenimentGeneric<VanzatorDTO>(vanzatorDTO));
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
