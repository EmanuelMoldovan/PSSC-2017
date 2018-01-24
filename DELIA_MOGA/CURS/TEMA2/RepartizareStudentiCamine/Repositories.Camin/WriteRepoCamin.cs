using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Modele.Camin;
using Modele.Camin.DTO;
using Modele.Evenimente;

namespace Repositories.Camin
{
    public class WriteRepoCamin
    {
        public SesiuneInscrieriCamin ProgrameazaSesiuneInscriere(SesiuneInscrieriCaminDTO sesiune)
        {
            var sesiuneNoua = new SesiuneInscrieriCamin(sesiune);
            SalvareEvenimente(sesiuneNoua.EvenimenteNoi);
            SalvareListaSesiuni(sesiune);
            return sesiuneNoua;
        }
        private void SalvareListaSesiuni(SesiuneInscrieriCaminDTO sesiune)
        {
            List<SesiuneInscrieriCaminDTO> toateSesiunile = new List<SesiuneInscrieriCaminDTO>();
            if (File.Exists("sesiuniDeInscriereInCamin.json"))
            {
                toateSesiunile = JsonConvert.DeserializeObject<List<SesiuneInscrieriCaminDTO>>(File.ReadAllText("sesiuniDeInscriereInCamin.json"));
            }
            toateSesiunile.Add(sesiune);
            
            File.WriteAllText("sesiuniDeInscriereInCamin.json", JsonConvert.SerializeObject(toateSesiunile));
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

        public SesiuneInscrieriCaminDTO GasesteSesiune(SesiuneInscrieriCaminDTO sesiune)
        {
            SesiuneInscrieriCaminDTO gasit = new SesiuneInscrieriCaminDTO();
            List<SesiuneInscrieriCaminDTO> toateSesiunile = new List<SesiuneInscrieriCaminDTO>();
            if (File.Exists("sesiuniDeInscriereInCamin.json"))
            {
                toateSesiunile = JsonConvert.DeserializeObject<List<SesiuneInscrieriCaminDTO>>(File.ReadAllText("sesiuniDeInscriereInCamin.json"));
                gasit = toateSesiunile.Find(x => x.NumeCamin.NumeCamin.Equals(sesiune.NumeCamin.NumeCamin));
                if (gasit.NumeCamin.ToString() != null) //creez metoda in clasa
                {
                    Console.WriteLine("Evenimentul sesiunii de inscrieri in " + gasit.NumeCamin.NumeCamin + " a fost gasit!");
                }
            }
            return gasit;
        }
    }
}
