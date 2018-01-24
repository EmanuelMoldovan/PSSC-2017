using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using Modele.Generic;

namespace Modele.Organizator
{
    public class Organizator
    {
        public TextNume nume { get; set; }
        private int varsta { get; set; }
        public List<string> feedBack { get; set; }
        private GradOrganizator Grad { get; set; }

        public Organizator(TextNume nume, int varsta, GradOrganizator grad)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.feedBack = new List<string>();
            this.Grad = grad;
        }

        public void getFeedback(string feedBack)
        {
            Contract.Requires(feedBack != null, "feedBack null");
            Contract.Requires(feedBack.Length < 200, "feedBack prea lung");
            this.feedBack.Add(feedBack);
        }
        


    }
}
