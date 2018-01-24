using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using Modele.Camin.DTO;

namespace Repositories.Camin
{
    public class ReadRepoCamin
    {
        public IEnumerable<SesiuneInscrieriCaminDTO> ObtineSesiuniInscrieri()
        {
            List<SesiuneInscrieriCaminDTO> toateSesiunile = new List<SesiuneInscrieriCaminDTO>();
            if (File.Exists("sesiuniDeInscriereInCamin.json"))
            {
                toateSesiunile = JsonConvert.DeserializeObject<List<SesiuneInscrieriCaminDTO>>(File.ReadAllText("sesiuniDeInscriereInCamin.json"));
            }
            return toateSesiunile.AsEnumerable();
        }
    }
}
