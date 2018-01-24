using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Student.DTO
{
    public class StudentDTO
    {
        public PlainText NumeStudent { get; set; }
        public NrMatricol NrMatricol { get; set; }
        public PlainText Facultate { get; set; }
        public Nota Medie { get; set; }
        public Camin NumeCaminAles { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", NumeStudent, Medie, NumeCaminAles.NumeCamin);
        }
    }
}
