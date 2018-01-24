using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brand;
using State;
namespace Disciplina
{
    public class Disciplina
    {
        public string NumeDisciplina;
        private List<Brand.Brand> ListaBranduri;
        public State.Stare Stare;
        public Inventar.Inventar Inventar;

        internal Disciplina(string Nume)
        {
            this.NumeDisciplina = Nume;
            this.ListaBranduri = new List<Brand.Brand>();
            this.Stare = new State.Stare();
            this.Inventar = new Inventar.Inventar();
        }

        internal Disciplina(string Nume, List<Brand.Brand> ListaBrand)
        {
            this.NumeDisciplina = Nume;
            this.ListaBranduri = ListaBrand;
            this.Stare = new State.Stare();
            this.Inventar = new Inventar.Inventar();
        }

        public void AdaugaBrand(Brand.Brand brand)
        {
            if (Stare == State.Stare.Cumparare)
            {
                ListaBranduri.Add(brand);
            }
            else
            {
                Console.WriteLine("Nu suntem in perioada de cumparare");
            }
            
        }

        public void StergeBrand(string brand)
        {
            if (Stare == State.Stare.Vanzare)
            {
                var lista = ListaBranduri.First(s => s.Nume.Equals(brand));

                Inventar.ListaInventar.Add(lista);

                ListaBranduri.Remove(lista);
            }
            else
            {
                Console.WriteLine("Nu suntem in perioada de vanzare");
            }
           
        }

        public bool BrandExist(string brand)
        {
           Brand.Brand br = null;
            br = ListaBranduri.FirstOrDefault(s => s.Nume.Equals(brand));
            if (br==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool MasinaExist(string brand,string model)
        {
            Brand.Brand br = null;
            Masina.Masina ms = null;
            br = ListaBranduri.FirstOrDefault(s => s.Nume.Equals(brand));
            ms = br.ListaMasini.FirstOrDefault(s => s.Model.Equals(model));
            if (ms == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AdaugaMasini(string brand,Masina.Masina masina)
        {
            if (Stare == State.Stare.Cumparare)
            {
                var lista = ListaBranduri.First(s => s.Nume.Equals(brand));
                lista.ListaMasini.Add(masina);
            }
            else
            {
                Console.WriteLine("Nu suntem in perioada de cumparare");
            }
           
        }

        public void StergeMasina(string brand,string model)
        {
            if (Stare == State.Stare.Vanzare)
            {
                var lista = ListaBranduri.First(s => s.Nume.Equals(brand));
                var lst = lista.ListaMasini.First(s => s.Model.Equals(model));

                Inventar.ListaInventar.Add(lista);

                lista.ListaMasini.Remove(lst);
            }
            else
            {
                Console.WriteLine("Nu suntem in perioada de vanzare");
            }
            
        }
        public void IncepeCumpararea()
        {
            Stare = State.Stare.Cumparare;
        }
        public void IncepeVanzarea()
        {
            Stare = State.Stare.Vanzare;
        }
        public void IncepeInventarul()
        {
            Stare = State.Stare.Inventar;
        }


        public override string ToString()
        {
            string sir;
            sir = "Disciplina: " + NumeDisciplina.ToString()+"\n";
            foreach(Brand.Brand b in ListaBranduri)
            {
                sir += b.ToString();
            }
            return sir;
        }
    }
}
