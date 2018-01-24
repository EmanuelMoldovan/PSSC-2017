using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect.Models
{
    public class Confirmare
    {
        public String id { get; set; }
        public String data { get; set; }
        public String partenerTranzactie { get; set; }
        public double suma { get; set; }
        public String tipTranz { get; set; }
    }
}