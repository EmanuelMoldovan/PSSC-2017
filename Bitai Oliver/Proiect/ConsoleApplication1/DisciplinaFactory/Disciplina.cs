using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisciplinaFactory
{
    public class Disciplina
    {
        public string NumeDisciplina;
        private List<Tip> ListaTipuri;
        public State.Stare Stare;
        public Inventar Inventar;

        internal Disciplina(string Nume)
        {
            this.NumeDisciplina = Nume;
            this.ListaTipuri = new List<Tip>();
            this.Stare = new State.Stare();
            this.Inventar = new Inventar();
        }

       internal Disciplina(string Nume, List<Tip> ListaTip)
        {
            this.NumeDisciplina = Nume;
            this.ListaTipuri = ListaTip;
            this.Stare = new State.Stare();
            this.Inventar = new Inventar();
        }

        public void AdaugaTip(Tip tip)
        {
            if (Stare == State.Stare.Cumparare)
            {
                ListaTipuri.Add(tip);
            }
            else
            {
                Console.WriteLine("Nu suntem in perioada de cumparare");
            }

        }

        public void StergeTip(string tip)
        {
            if (Stare == State.Stare.Vanzare)
            {
                var lista = ListaTipuri.First(s => s.Nume.Equals(tip));

                Inventar.ListaInventar.Add(lista);

                ListaTipuri.Remove(lista);
            }
            else
            {
                Console.WriteLine("Nu suntem in perioada de vanzare");
            }
        }

        public void AdaugaProdus(string tip, Produs prod)
        {
            if (Stare == State.Stare.Cumparare)
            {
                var lista = ListaTipuri.First(s => s.Nume.Equals(tip));
                lista.ListaProduse.Add(prod);
            }
            else
            {
                Console.WriteLine("Nu suntem in perioada de cumparare");
            }

        }

        public void StergeProdus(string tip, string nume)
        {
            if (Stare == State.Stare.Vanzare)
            {
                var lista = ListaTipuri.First(s => s.Nume.Equals(tip));
                var lst = lista.ListaProduse.First(s => s.Nume.Equals(nume));

                var lista1 = Inventar.ListaInventar.FirstOrDefault(s => s.Nume.Equals(tip));
                if (lista1 != null)
                {
                    lista1.ListaProduse.Remove(lst);
                }
                else
                {
                    lista.ListaProduse.Remove(lst);
                    Inventar.ListaInventar.Add(lista);
                }
     
            }
            else
            {
                Console.WriteLine("Nu suntem in perioada de vanzare");
            }
        }

        public void StergeProdus(string tip, string nume, int catitate)
        {
            if (Stare == State.Stare.Vanzare)
            {
               
                var lista = ListaTipuri.First(s => s.Nume.Equals(tip));
                var lst = lista.ListaProduse.First(s => s.Nume.Equals(nume));
                
                if(lst.NrBucati>=catitate)
                {
                    //if (Inventar.ListaInventar.Contains<Tip>(lista))
                    var lista1=Inventar.ListaInventar.FirstOrDefault(s => s.Nume.Equals(tip));
                    if(lista1!=null)
                    {
                        var lst1 = lista1.ListaProduse.FirstOrDefault(s => s.Nume.Equals(nume));
                        if (lst1!=null)
                        {
                            lst1.NrBucati += catitate;
                        }
                        else
                        {
                            lista1.ListaProduse.Add(lst);
                            lst1 = lista1.ListaProduse.First(s => s.Nume.Equals(nume));
                            lst1.NrBucati = catitate;
                        }
                       
                        lst.NrBucati -= catitate;
                        if(lst.NrBucati<=0)
                        {
                            lista.ListaProduse.Remove(lst);
                        }
                    }
                    else
                    {
                        Inventar.ListaInventar.Add(lista);
                        
                        Tip lista11 = Inventar.ListaInventar.First(s => s.Nume.Equals(tip));
                        Produs p = new Produs(lista11.ListaProduse.First(s => s.Nume.Equals(nume)));
                        List<Produs> pl = new List<Produs>();
                        pl.Add(p);
                        Tip l = new Tip(tip,pl);

                        var lst1 = l.ListaProduse.First(s => s.Nume.Equals(nume));
                        lst1.NrBucati = catitate;
                        Inventar.ListaInventar.Remove(lista11);
                        Inventar.ListaInventar.Add(l);

                        lst.NrBucati -= catitate;
                        if (lst.NrBucati <= 0)
                        {
                            lista.ListaProduse.Remove(lst);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nu sunt suficient de mult de produse!!");
                }
                
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

        public bool TipExist(string tip)
        {
            Tip tp = null;
            tp = ListaTipuri.FirstOrDefault(s => s.Nume.Equals(tip));
            if (tp == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ProdusExist(string tip, string nume)
        {
            Tip tp = null;
            Produs num = null;
            tp = ListaTipuri.FirstOrDefault(s => s.Nume.Equals(tip));
            num = tp.ListaProduse.FirstOrDefault(s => s.Nume.Equals(nume));
            if (num == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            string sir;
            sir = "Disciplina: " + NumeDisciplina.ToString() + "\n";
            foreach (Tip b in ListaTipuri)
            {
                sir += b.ToString();
            }
            return sir;
        }

    }
}
