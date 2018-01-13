using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont.Model.DTOs
{
    public class SerializedCommandDTO
    {
        [JsonProperty(PropertyName = "tip")]
        public String TipTranzactie { get; set; } //depunere/transfera

        [JsonProperty(PropertyName = "suma")]
        public double suma { get; set; }

        [JsonProperty(PropertyName = "conturi")]
        public List<ContDTO> conturi { get; set; } 
        //in cazul depunerii va avea un singur element
        //in cazul tranzactiei primul element va fi contul sursei, urm element contul destinatarului


        public SerializedCommandDTO()
        {
            //empty constructor for deserialization
        }

        public SerializedCommandDTO(double sum, ContDTO source, ContDTO destination)
        {
            this.TipTranzactie = "transfera";
            this.suma = sum;
            this.conturi = new List<ContDTO>();
            this.conturi.Add(source);
            this.conturi.Add(destination);
        }

        public SerializedCommandDTO(double sum, ContDTO source)
        {
            this.TipTranzactie = "depunere";
            this.suma = sum;
            this.conturi = new List<ContDTO>();
            this.conturi.Add(source);
        }

        public String Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
