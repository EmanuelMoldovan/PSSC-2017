
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using Modele.LimbaStraina;
using System.Diagnostics.Contracts;

namespace Modele.Cursanti
{
    public class Cursant
    {
        public int Id { get; internal set; }
        public string Nume { get; internal set; }
        
        public NivelLimba Nivel { get; internal set; }
        LimbaStrainaFactory limbaStrainaAleasa;
         public Cursant(int id, string nume)
    {
        Contract.Requires(id != null, "id");
        Contract.Requires(nume != null, nume);
            Id = id;
            Nume = nume;
    }


       
    }
}
