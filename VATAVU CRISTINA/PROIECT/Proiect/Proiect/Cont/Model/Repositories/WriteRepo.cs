using Cont.Model.DTOs;
using Modele.Cont;
using Modele.Generic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont.Repositories
{
    public class WriteRepo : GenericRepo
    {
        public WriteRepo()
			: base("")
		{

        }

        public WriteRepo(string rootPath)
			:base(rootPath)
		{
        }


        private List<ContDTO> IncarcaListaDeConturi(string iban)
        {
            List<ContDTO> toateConturile = new List<ContDTO>();
            if (ExistaFisier("account.json"))
            {
                toateConturile = JsonConvert.DeserializeObject<List<ContDTO>>(CitesteContinutFisier("account.json"));
            }
            return toateConturile;
        }


        public ContDTO GasesteCont(string iban)
        {
            var cont = IncarcaListaDeConturi(iban)
                                    .Where(e => e.iban == iban);
            if(cont == null)
            {
                List<ContDTO> conturi = new List<ContDTO>();
                ContDTO c = new ContDTO();
                conturi.Add(c);
                var ret = conturi.First();
                return ret;
            }
            else
            {
                ContDTO gasit = cont.First();
                return gasit;
            }
        }
 

        public void ActualizareContInLista(ContDTO cont, double soldNou)
        {
            var lista = IncarcaListaDeConturi(cont.iban);
            var contInLista = lista.Where(m => m.iban == cont.iban).First();
            contInLista.Sold = soldNou;
            SalvareListaConturi(lista);
        }


        private void SalvareListaConturi(List<ContDTO> toateConturile)
        {
            ScrieContinutFisier("account.json", JsonConvert.SerializeObject(toateConturile));
        }







        private List<TranzactieDTO> IncarcaListaDeTranzExistente(string iban)
        {
            List<TranzactieDTO> toateTranz = new List<TranzactieDTO>();
            if (ExistaFisier(iban + ".json"))
            {
                toateTranz = JsonConvert.DeserializeObject<List<TranzactieDTO>>(CitesteContinutFisier(iban + ".json"));
            }
            return toateTranz;
        }


        public void AdaugaTranzactie(TranzactieDTO tranz, String ibanUser)
        {
            SalavareTranzactieInListaTranzactii(tranz, ibanUser);
        }

        private void SalavareTranzactieInListaTranzactii(TranzactieDTO tranz, string iban)
        {
            List<TranzactieDTO> toateTranzExistente = IncarcaListaDeTranzExistente(iban);
            if(toateTranzExistente == null)
            {
                toateTranzExistente = new List<TranzactieDTO>();
            }
            toateTranzExistente.Add(tranz);
            SalvareListaTranzactii(toateTranzExistente, iban);
        }

        private void SalvareListaTranzactii(List<TranzactieDTO> toateTranz, string iban)
        {
            ScrieContinutFisier(iban+".json", JsonConvert.SerializeObject(toateTranz));
        }




    }
}
