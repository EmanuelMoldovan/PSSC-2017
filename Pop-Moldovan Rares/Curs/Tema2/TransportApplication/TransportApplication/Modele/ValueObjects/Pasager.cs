

namespace TransportApplication.Modele.ValueObjects
{
    public class Pasager
    {
        private string numePasager;

        public  Pasager(string numePasager)
        {
            this.numePasager = numePasager;
        }

        public Pasager() { }

        override
        public string ToString()
        {
            return "Nume pasager: " + numePasager;
        }
        #region
        public string NUME_PASAGER
        {
            get { return numePasager; }
            set { numePasager = value; }
        }
        #endregion
    }
}
