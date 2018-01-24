using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApplication.Modele.Entitati
{
    public class Sofer
    {
        private string numeSofer;
        private string cnp;
        private int varsta;

        public Sofer(string numeSofer,string cnp, int varsta)
        {
            this.numeSofer = numeSofer;
            this.cnp = cnp;
            this.varsta = varsta;
        }

        public Sofer() { }

        override
        public string ToString()
        {
            return  numeSofer + " " + cnp + " " + varsta;
        }
        #region Getteri si Setter
        public string NUME_SOFER
        {
            get { return numeSofer; }
            set { numeSofer = value; }
        }

        public string CNP
        {
            get { return cnp; }
            set { cnp = value; }
        }
        public int VARSTA_SOFER
        {
            get { return varsta; }
            set { varsta = value; }
        }
        #endregion
    }
}
