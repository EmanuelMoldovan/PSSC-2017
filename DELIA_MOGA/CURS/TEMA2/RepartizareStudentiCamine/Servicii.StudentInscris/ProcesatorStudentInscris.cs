using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.StudentiInscrisi;

namespace Servicii.StudentInscris
{
    public class ProcesatorStudentInscris
    {
        public object WriteRepoStudentiInscrisiCamin { get; private set; }

        public void Procesare(ComandaStudentInscris comanda)
        {
            //var repo = new ReadRepoFacultate();
            //var student = repo.ObtineDetaliiStudent(comanda.Student.NrMatricol);
            var repo1 = new WriteRepoStudentiInscrisiCamin();
            repo1.InscrieStudent(comanda.Student);
        }
    }
}
