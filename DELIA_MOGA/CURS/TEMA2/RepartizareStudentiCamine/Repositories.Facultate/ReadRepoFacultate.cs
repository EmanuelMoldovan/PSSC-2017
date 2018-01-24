using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Modele.Generic;
using Modele.Camin.DTO;

namespace Repositories.Facultate
{
    public class ReadRepoFacultate
    {
        public StudentDTO ObtineDetaliiStudent(NrMatricol nrMatricol)
        {
            List<StudentDTO> totiStudentii = new List<StudentDTO>();
            if (File.Exists("detaliiStudentFacultate.json"))
            {
                totiStudentii = JsonConvert.DeserializeObject<List<StudentDTO>>(File.ReadAllText("detaliiStudentFacultate.json"));
            }
            var student = totiStudentii.Find(x => x.NrMatricol == nrMatricol);

            return student;
        }
    }
}
