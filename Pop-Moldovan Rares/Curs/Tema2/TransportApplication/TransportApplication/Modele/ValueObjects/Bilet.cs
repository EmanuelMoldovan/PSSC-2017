
namespace TransportApplication.Modele.ValueObjects
{
    public class Bilet
    {
        private string destinatie;
        private string oraPlecare;
        private string oraSosire;
        private string locplecare;

        public Bilet(string locplecare, string oraPlecare, string destinatie,string oraSosire)
        {
            this.locplecare = locplecare;
            this.destinatie = destinatie;
            this.oraPlecare = oraPlecare;
            this.oraSosire = oraSosire;
        }

        public Bilet() { }

        override 
        public string ToString()
        {
            return locplecare + " " + destinatie + " " + oraPlecare + " " + oraSosire;
        }

        #region Getter si Setteri
        public string BILET_PLECARE
        {
            get { return locplecare; }
            set { locplecare = value; }
        }
        public string BILET_DESTINAITE
        {
            get { return destinatie; }
            set { destinatie = value; }
        }

        public string BILET_ORA_PLECARE
        {
            get { return oraPlecare; }
            set { oraPlecare = value; }
        }

        public string BILET_ORA_SOSIRE
        {
            get { return oraSosire; }
            set { oraSosire = value; }
        }
        #endregion
    }
}
