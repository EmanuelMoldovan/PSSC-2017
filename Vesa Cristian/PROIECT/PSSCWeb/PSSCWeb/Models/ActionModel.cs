using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PSSCWeb.Models
{
    public class ActionModel
    {
        public Guid Id { get; set; }
        public DateTime DateForAction { get; set; }

        public ActionTypeWeb _ActionType { get; set; }
        [Required(ErrorMessage = "Sum is required")]
        public float Money { get; set; }
    }
}