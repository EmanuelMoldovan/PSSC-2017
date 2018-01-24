
using System.Collections.Generic;

namespace TransportApplication.Modele.Entitati
{
    public class Autocar
    {
        private string marca;
        private string model;
        private string nrInmat;
        private string anFab;

        public Autocar(string marca,string model, string nrInmat,string anFab)
        {
            this.marca = marca;
            this.model = model;
            this.nrInmat = nrInmat;
            this.anFab = anFab;
        }

        public Autocar() { }

        override
        public string ToString()
        {
            return marca + " " + model + " " + nrInmat + " " + anFab;
        }
        #region Getter si Setteri
        public string MARCA
        {
            get { return marca; }
            set { marca = value; }
        }
        public string MODEL
        {
            get { return model; }
            set { model = value; }
        }
        public string NR_INMATRICULARE
        {
            get { return nrInmat; }
            set { nrInmat = value; }
        }
        public string AN_FABRICATIE
        {
            get { return anFab; }
            set { anFab = value; }
        }
        #endregion
    }
}
