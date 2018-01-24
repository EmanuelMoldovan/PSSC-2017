using Core.Identity_and_access_layer.Models;
using Core.Persons_layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Identity_and_access_layer
{
    public class UserPersonTuple
    {
        public Persoana ModelPersoana {get;set;}
        public User ModelUser { get; set; }
    }
}