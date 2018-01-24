using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Camin;
using Modele.Camin.DTO;
using Modele.Evenimente;
using Newtonsoft.Json;

namespace Repositories.StudentiInscrisi
{
    public class WriteRepoStudentiInscrisiCamin
    {
        public Student InscrieStudent(StudentDTO student)
        {
            var studentNou = new Student(student);
            SalvareEvenimente(studentNou.EvenimenteNoi);
            SalvareListaStudenti(student);
            return studentNou;
        }
        private void SalvareListaStudenti(StudentDTO student)
        {
            List<StudentDTO> totiStudentii = new List<StudentDTO>();
            if (File.Exists("studentiInscrisiInCamin.json"))
            {
                totiStudentii = JsonConvert.DeserializeObject<List<StudentDTO>>(File.ReadAllText("studentiInscrisiInCamin.json"));
            }
            totiStudentii.Add(student);
            
            File.WriteAllText("studentiInscrisiInCamin.json", JsonConvert.SerializeObject(totiStudentii));
        }

        private void SalvareEvenimente(ReadOnlyCollection<Eveniment> evenimenteNoi)
        {
            List<Eveniment> toateEvenimentele = new List<Eveniment>();
            if (File.Exists("log.json"))
            {
                toateEvenimentele = JsonConvert.DeserializeObject<List<Eveniment>>(File.ReadAllText("log.json"));
            }
            toateEvenimentele.AddRange(evenimenteNoi);
            File.WriteAllText("log.json", JsonConvert.SerializeObject(toateEvenimentele));
        }

    }
}
