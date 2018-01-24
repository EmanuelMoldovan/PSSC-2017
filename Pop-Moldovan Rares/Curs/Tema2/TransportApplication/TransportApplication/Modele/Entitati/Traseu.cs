

namespace TransportApplication.Modele.Entitati
{
    public class Traseu
    {
        private string locPlecare;
        private string locSosire;
        private string oraPlecare;
        private string oraSosire;

        //Constructor cu parametrii
        public Traseu(string locPlecare,string locSosire, string oraPlecare,string oraSosire)
        {
            this.locPlecare = locPlecare;
            this.oraPlecare = oraPlecare;
            this.locSosire = locSosire;
            this.oraSosire = oraSosire; 
        }

        public Traseu()
        {

        }

        override
        public string ToString()
        {
            return locPlecare + " " + oraPlecare + " " + locSosire + " " + oraSosire;
        }
        #region Getteri si Setteri
        //getter si setter
        public string LOC_PLECARE
        {
            get { return locPlecare; }
            set { locPlecare = value; }
        }

        public string LOC_SOSIRE
        {
            get { return locSosire; }
            set { locSosire = value; }
        }

        public string ORA_PLECARE
        {
            get { return oraPlecare; }
            set { oraPlecare = value; }
        }

        public string ORA_SOSIRE
        {
            get { return oraSosire; }
            set { oraSosire = value; }
        }
    #endregion
    }
}
