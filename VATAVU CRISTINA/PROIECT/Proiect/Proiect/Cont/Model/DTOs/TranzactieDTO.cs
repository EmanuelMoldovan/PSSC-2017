using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont.Model.DTOs
{
    public class TranzactieDTO
    {
        [JsonProperty(PropertyName = "data")]
        public String data;

        [JsonProperty(PropertyName = "partenerTranzactie")]
        public String partenerTranzactie;

        [JsonProperty(PropertyName = "suma")]
        public double suma;

        [JsonProperty(PropertyName = "tipTranz")]
        public String tipTranz;
    }
}
