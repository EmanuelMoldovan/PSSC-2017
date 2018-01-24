using Cont.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cont.Repositories
{
    public class ReadRepo : GenericRepo
    {
        public ReadRepo(string rootPath)
			:base (rootPath)
		{
        }

        public ReadRepo()
			:base("")
		{
        }

        public IEnumerable<ContDTO> ObtineConturi()
        {
            List<ContDTO> toateConturile = new List<ContDTO>();
            if (ExistaFisier("account.json"))
            {
                //toateConturile = JsonConvert.DeserializeObject<List<ContDTO>>(CitesteContinutFisier("account.json"));
                toateConturile = JsonConvert.DeserializeObject<List<ContDTO>>(CitesteContinutFisier("account.json"));
            }
            else
            {
                ContDTO c = new ContDTO();
                toateConturile.Add(c); //adaugat !!
            }
            return toateConturile.AsEnumerable();
        }

        public ContDTO CautaCont(string iban)
        {
            return ObtineConturi().Where(m => m.iban == iban).FirstOrDefault();
        }

        public List<TranzactieDTO> ObtineTranzactii(string iban)
        {
            List <TranzactieDTO> toateTranz =  new List<TranzactieDTO>();
            if (ExistaFisier(iban+".json"))
            {
                //toateConturile = JsonConvert.DeserializeObject<List<ContDTO>>(CitesteContinutFisier("account.json"));
                toateTranz = JsonConvert.DeserializeObject<List<TranzactieDTO>>(CitesteContinutFisier(iban + ".json"));
            }
            else
            {
                TranzactieDTO c = new TranzactieDTO();
                toateTranz.Add(c); //adaugat !!
            }
            return toateTranz;
        }
    }
}
