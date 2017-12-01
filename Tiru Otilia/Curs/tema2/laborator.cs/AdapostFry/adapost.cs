using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapost
{
    class Adapost
    {
        public string NumeAdapost;
        private List<rasa.rasa> Listarasaa;

        internal Adapost(string Nume)
        {
            this.NumeAdapost = Nume;
            this.Listarasa = new List<rasa.rasa>();
        }

        internal Adapost(string Nume, List<rasa.rasa> Listarasa)
        {
            this.NumeAdapost = Nume;
            this.Listarasaa = Listarasa;
        }

        public void Adaugarasa(rasa.rasa rasa)
        {
            Listarasaa.Add(rasa);
        }

        public void Stergerasa(string rasa)
        {
            var lista = Listarasaa.First(s => s.Nume.Equals(rasa));
            Listarasaa.Remove(lista);
        }

        public bool rasaExist(string rasa)
        {
            rasa.rasa br = null;
            br = Listarasaa.FirstOrDefault(s => s.Nume.Equals(rasa));
            if (br == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Adaugavietati(string rasa, Animal.Animal Animal)
        {
            var lista = Listarasaa.First(s => s.Nume.Equals(rasa));
            lista.Listavietati.Add(Animal);
        }

        public void StergeAnimal(string rasa, string model)
        {
            var lista = Listarasaa.First(s => s.Nume.Equals(rasa));
            var lst = lista.Listavietati.First(s => s.Model.Equals(model));
            lista.Listavietati.Remove(lst);
        }


        public override string ToString()
        {
            string sir;
            sir = "Adapost: " + NumeAdapost.ToString() + "\n";
            foreach (rasa.rasa b in Listarasaa)
            {
                sir += b.ToString();
            }
            return sir;

        }
    }
}
