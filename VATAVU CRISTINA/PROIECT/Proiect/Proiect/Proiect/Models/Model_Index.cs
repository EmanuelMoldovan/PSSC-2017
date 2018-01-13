using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proiect.Models
{
    public class Model_Index
    {
        //The data from the form is mapped to this model
        [Required]
        public string IBAN { get; set; }
        public double SumaDep{ get; set; }
        public string IBANdest { get; set; }
        public double SumaTransf { get; set; }

    }
}