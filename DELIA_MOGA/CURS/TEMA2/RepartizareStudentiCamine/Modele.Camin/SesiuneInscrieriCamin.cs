using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Camin.DTO;
using Modele.Evenimente;
using Modele.Generic;

namespace Modele.Camin
{
    public class SesiuneInscrieriCamin
    {
        private readonly List<Eveniment> _evenimenteNoi = new List<Eveniment>();
        public ReadOnlyCollection<Eveniment> EvenimenteNoi
        {
            get
            {
                return _evenimenteNoi.AsReadOnly();
            }
        }
        public Camin NumeCamin { get; private set; }
        public DateTime DataStart { get; private set; }
        public DateTime DataStop { get; private set; }
        public Durata DurataZile { get; set; }
        public SesiuneInscrieriCaminStare Stare { get; private set; }
        public event EventHandler<Eveniment> EvenimentInscriere;

        public SesiuneInscrieriCamin(SesiuneInscrieriCaminDTO sesiuneDTO)
        {
            DataStart = sesiuneDTO.DataStart;
            DataStop = sesiuneDTO.DataStop;
            NumeCamin = sesiuneDTO.NumeCamin;
            DurataZile = sesiuneDTO.DurataZile;

            PublicaEveniment(new EvenimentGeneric<SesiuneInscrieriCaminDTO>(sesiuneDTO));
        }

        public void Start()
        {
            DataStart = DateTime.Now;
            Console.WriteLine("Startul inscrierilor a fost dat.");
            PublicaEveniment(new EvenimentGeneric<DateTime>(DataStart));
        }

        public void Stop()
        {
            DataStop = DateTime.Now;
            Console.WriteLine("Perioada inscrierilor a luat sfarsit.");
            PublicaEveniment(new EvenimentGeneric<DateTime>(DataStop));
        }

        public void InscriereStudentCamin(Student student)
        {
            //adaug la lista studentul 

            var eveniment = new EvenimentGeneric<Student>(student);
            PublicaEveniment(eveniment);
        }

        protected void PublicaEveniment(Eveniment eveniment)
        {
            _evenimenteNoi.Add(eveniment);
            if (EvenimentInscriere != null)
            {
                EvenimentInscriere(this, eveniment);
            }
        }
    }
}
