using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont.Model.DTOs
{
    public class SerializedResultDTO
    {
        [JsonProperty(PropertyName = "tip")]
        public String TipTranzactie { get; set; } //depunere/transfera

        [JsonProperty(PropertyName = "tranzactii")]
        public List<TranzactieDTO> tranzactii { get; set; }
        //in cazul depunerii va avea un singur element
        //in cazul tranzactiei primul va fi tranactia sursei, a 2-a va fi tranzactia destinatarului


        [JsonProperty(PropertyName = "conturi")]
        public List<ContDTO> conturi { get; set; }
        //in cazul depunerii va avea un singur element
        //in cazul tranzactiei primul va fi contul sursa, a 2-a va fi contul destinatie


        public SerializedResultDTO()
        {
            //empty constructor for deserialization
        }

        public SerializedResultDTO(ContDTO source, ContDTO destination, TranzactieDTO sourceTr, TranzactieDTO destinationTr)
        {
            this.TipTranzactie = "transfera";
            this.conturi = new List<ContDTO>();
            this.conturi.Add(source);
            this.conturi.Add(destination);
            this.tranzactii = new List<TranzactieDTO>();
            tranzactii.Add(sourceTr);
            tranzactii.Add(destinationTr);
        }

        public SerializedResultDTO(ContDTO source, TranzactieDTO sourceTr)
        {
            this.TipTranzactie = "depunere";
            this.conturi = new List<ContDTO>();
            this.conturi.Add(source);
            this.tranzactii = new List<TranzactieDTO>();
            tranzactii.Add(sourceTr);
        }

        public String Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
