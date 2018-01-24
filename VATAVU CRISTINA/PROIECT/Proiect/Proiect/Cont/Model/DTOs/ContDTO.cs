using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont.Model.DTOs
{
     public class ContDTO
    {
        [JsonProperty(PropertyName = "IBAN")]
        public string iban { get; set; }

        //public Tranzactii istoric;

        [JsonProperty(PropertyName = "name")]
        public string client { get; set; }

        [JsonProperty(PropertyName = "sold")]
        public double Sold { get; set; }
    }
}
