using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using PSSC.Models.DTO;
namespace PSSCWeb.Models
{
    public class ContModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "AccountNumber is required")]
        public string AccountNumber { get; set; }

        [Required(ErrorMessage = "Currency is required")]
        public string Currency { get; set; }

        public float MoneyDeposited { get; set; } = 0;

        public string User { get; set; }

        public List<ActionDTO> myAction { get; set; }
    }
}