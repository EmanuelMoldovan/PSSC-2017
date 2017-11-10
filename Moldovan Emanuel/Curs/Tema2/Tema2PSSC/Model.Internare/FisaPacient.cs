using Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Internare
{
    public class FisaPacient
    {
        public Doctor Doctor { get; internal set; }
        public PlainText CodFisa { get; internal set; }

        public FisaPacient(PlainText codFisa)
        {
            CodFisa = codFisa;
        }
        public FisaPacient(Doctor doctor, PlainText codFisa)
        {
            Doctor = doctor;
            CodFisa = codFisa;
        }

        public Doctor GetDoctor()
        {
            return Doctor;
        }

        public Asistent GetAsistent(string nume)
        {
            return Doctor.GetAsistente().FirstOrDefault(d => d.Nume.Text == nume);
        }

        public Pacient GetPacient(string numeAsistent, string numePacient)
        {
            return GetAsistent(numeAsistent).GetPacienti().FirstOrDefault(d => d.Nume.Text == numePacient);
        }

        #region operatii
        public void ActualizeazaDoctor(Doctor doctor)
        {
            Doctor = doctor;
        }

        public void ActualizeazaCodFisa(PlainText codFisa)
        {
            CodFisa = codFisa;
        }
        #endregion
    }
}
