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
    public class Student
    {
        private readonly List<Eveniment> _evenimenteNoi = new List<Eveniment>();
        public ReadOnlyCollection<Eveniment> EvenimenteNoi
        {
            get
            {
                return _evenimenteNoi.AsReadOnly();
            }
        }

        public PlainText NumeStudent { get; private set; }
        public NrMatricol NrMatricol { get; private set; }
        public PlainText Facultate { get; private set; }
        public Nota Medie { get; private set; }
        public Camin NumeCaminAles { get; set; }
        public StudentStare Stare { get; private set; }

        public event EventHandler<Eveniment> EvenimentMeci;

        public Student(StudentDTO studentDto)
        {
            NumeStudent = studentDto.NumeStudent;
            NrMatricol = studentDto.NrMatricol;
            Medie = studentDto.Medie;
            Facultate = studentDto.Facultate;
            NumeCaminAles = studentDto.NumeCaminAles;

            PublicaEveniment(new EvenimentGeneric<StudentDTO>(studentDto));
        }

        protected void PublicaEveniment(Eveniment eveniment)
        {
            _evenimenteNoi.Add(eveniment);
            if (EvenimentMeci != null)
            {
                EvenimentMeci(this, eveniment);
            }
        }
    }
}
