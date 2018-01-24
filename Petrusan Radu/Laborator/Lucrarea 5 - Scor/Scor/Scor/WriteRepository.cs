using Scor.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;
using Scor.Model;

namespace Scor
{
	public class WriteRepository
	{
		public Meci ProgrameazaMeci(MeciDto meci)
		{
			var meciNou = new Meci(meci);
			SalvareEvenimente(meciNou.EvenimenteNoi);
			SalavareListaMeciuri(meci);
			return meciNou;
		}

        internal Meci GasesteMeci(MeciDto meci)
        {
            //	//load events

            //	//creare meci din evenimente

            return null;
        }

        private void SalavareListaMeciuri(MeciDto meci)
		{
			List<MeciDto> toateMeciurile = new List<MeciDto>();
			if (File.Exists("meciuri.json"))
			{
				toateMeciurile = JsonConvert.DeserializeObject<List<MeciDto>>(File.ReadAllText("meciuri.json"));
			}
			toateMeciurile.Add(meci);
			File.WriteAllText("meciuri.json", JsonConvert.SerializeObject(toateMeciurile));
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
