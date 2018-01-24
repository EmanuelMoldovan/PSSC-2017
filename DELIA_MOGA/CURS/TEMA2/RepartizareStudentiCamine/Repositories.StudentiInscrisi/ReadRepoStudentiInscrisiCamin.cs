using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Modele.Camin.DTO;
using Modele.Generic;
using Modele.Camin;

namespace Repositories.StudentiInscrisi
{
    public class ReadRepoStudentiInscrisiCamin
    {
        public IEnumerable<StudentDTO> ObtineDetaliiStudenti()
        {
            List<StudentDTO> totiStudentii = new List<StudentDTO>();
            if (File.Exists("studentiInscrisiInCamin.json"))
            {
                totiStudentii = JsonConvert.DeserializeObject<List<StudentDTO>>(File.ReadAllText("studentiInscrisiInCamin.json"));
            }

            return totiStudentii.AsEnumerable();
        }
      
        public RezultatRepartizare Repartizare(StudentDTO student, SesiuneInscrieriCaminDTO sesiune)
        {
            //           
            if (Nota.MaiMica(student.Medie, sesiune.NumeCamin.MedieMinimaNecesara))
            {
                Console.WriteLine("Studentul cu numele " + student.NumeStudent + " nu este admis in camin.");
                return RezultatRepartizare.RespinsMedieMica;
            }
            else
            {
                if (sesiune.NumeCamin.EstePlin)
                {
                    Console.WriteLine("Studentul cu numele " + student.NumeStudent + " nu este admis in camin. Nu mai sunt locuri disponibile.");
                    return RezultatRepartizare.RespinsLocuriOcupate;
                }
                else
                {
                    foreach (var camera in sesiune.NumeCamin.Camere)
                    {
                        if (!camera.EstePlina)
                        {
                            camera.Studenti.Add(new Student(student));
                            camera.esteGoala = false;
                            if (camera.Studenti.Count() == camera.NumarLocuriCamera)
                            {
                                camera.estePlina = true;
                            }
                            Console.WriteLine("Studentul cu numele " + student.NumeStudent + " este admis in camin in camera " + camera.NumarCamera);
                            return RezultatRepartizare.Admis;                            
                        }
                    }
                }
                return RezultatRepartizare.RespinsLocuriOcupate;
            }
           
        }
    }
}
