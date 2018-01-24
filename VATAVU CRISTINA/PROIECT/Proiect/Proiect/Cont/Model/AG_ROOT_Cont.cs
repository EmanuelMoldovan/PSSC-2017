using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic.Exceptions;


namespace Modele.Cont
{
    public class AG_ROOT_Cont
    {
        private IBAN iban;
        private Suma sold;
        private Tranzactii istoric;
        private Client client;

        public IBAN IBAN { get { return iban; } }
        public Suma Sold { get { return sold; } }
        public Tranzactii IstoricTranzactii{ get { return istoric; } }
        public Client DateClient { get { return client; } }


        public AG_ROOT_Cont()
        {

        }

        public AG_ROOT_Cont(IBAN iban, Client client)
        {
            this.iban = iban;
            this.sold = new Suma(0.0); //incepe de la 0
            this.istoric = new Tranzactii();
            this.client = client;
        }

        public AG_ROOT_Cont(IBAN iban, Client client, Suma sold)
        {
            this.iban = iban;
            this.sold = sold;
            this.istoric = new Tranzactii();
            this.client = client;
        }



        public AG_ROOT_Cont DepuneBani(Suma suma)
        {
            Tranzactie tranzactie = new Tranzactie(new ID(IstoricTranzactii.getTranzactii.Count()), this.IBAN, TipTranzactie.Depunere);
            //Contract.Requires<ArgumentException>(!tranzactie.Suma.getSuma.Equals(new Suma(0.0)), "suma sa fie !=0");
            tranzactie.SetSumaTranzactionata(suma);
            this.sold.getSuma += tranzactie.Suma.getSuma;
            IstoricTranzactii.AdaugaTranzactie(tranzactie);
            return this;
           // Console.WriteLine("Clientul: " + this.DateClient.Nume + " a depus " + suma.getSuma + " lei in contul sau");
        }

        public List<AG_ROOT_Cont> TransferBani(Suma sum, IBAN catre, List<AG_ROOT_Cont> conturi)
        {
            if (this.Sold.getSuma - sum.getSuma >= 0)
            {
                //ia banii din contul celui care transfera
                Tranzactie tranzactie = new Tranzactie(new ID(IstoricTranzactii.getTranzactii.Count()), catre, TipTranzactie.Transfer);
                Contract.Requires<ArgumentException>(!tranzactie.Suma.getSuma.Equals(new Suma(0.0)), "suma sa fie !=0");
                tranzactie.SetSumaTranzactionata(sum);
                this.sold.getSuma -= tranzactie.Suma.getSuma;
                this.IstoricTranzactii.AdaugaTranzactie(tranzactie);

                //depune in contul altuia, update contul impactat!!
                int indexDest = GasesteDestinatarul(catre, conturi);
                if (indexDest != -1)
                {
                    AG_ROOT_Cont destinatar = conturi.ElementAt(indexDest);
                    destinatar.sold.getSuma += tranzactie.Suma.getSuma;
                    Tranzactie tranzactie2 = new Tranzactie(new ID(destinatar.IstoricTranzactii.getTranzactii.Count()), this.iban, TipTranzactie.Depunere);
                    tranzactie2.SetSumaTranzactionata(sum);
                    destinatar.IstoricTranzactii.AdaugaTranzactie(tranzactie2);
                    Console.WriteLine("Clientul: " + this.DateClient.Nume + " a depus " + sum.getSuma + " lei in contul lui " + destinatar.DateClient.Nume);
                    return conturi; //returneaza lista de conturi cu informatiile updatate
                }
                else
                {
                    throw new AccountNotFoundException();
                }
            }
            else
            {
                throw new InsufficientFundsException();
            }

        }

        public List<AG_ROOT_Cont> PlatesteFactura(Suma sum, IBAN catre, List<AG_ROOT_Cont> conturi)
        {
            if (this.Sold.getSuma - sum.getSuma >= 0)
            {
                //ia banii din contul celui care transfera
                Tranzactie tranzactie = new Tranzactie(new ID(IstoricTranzactii.getTranzactii.Count()), catre, TipTranzactie.Factura);
                Contract.Requires<ArgumentException>(!tranzactie.Suma.getSuma.Equals(new Suma(0.0)), "suma sa fie !=0");
                tranzactie.SetSumaTranzactionata(sum);
                this.sold.getSuma -= tranzactie.Suma.getSuma;
                this.IstoricTranzactii.AdaugaTranzactie(tranzactie);

                //depune in contul altuia, update contul impactat!!
                int indexDest = GasesteDestinatarul(catre, conturi);
                if (indexDest != -1)
                {
                    AG_ROOT_Cont destinatar = conturi.ElementAt(indexDest);
                    destinatar.sold.getSuma += tranzactie.Suma.getSuma;
                    Tranzactie tranzactie2 = new Tranzactie(new ID(destinatar.IstoricTranzactii.getTranzactii.Count()), this.iban, TipTranzactie.Depunere);
                    tranzactie2.SetSumaTranzactionata(sum);
                    destinatar.IstoricTranzactii.AdaugaTranzactie(tranzactie2);
                    Console.WriteLine("Clientul: " + this.DateClient.Nume + " a platit o factura de " + sum.getSuma + " lei in contul lui " + destinatar.DateClient.Nume);
                    return conturi; //returneaza lista de conturi cu informatiile updatate
                }
                else
                {
                    throw new AccountNotFoundException();
                }
            }
            else
            {
                throw new InsufficientFundsException();
            }

        }

        private int GasesteDestinatarul(IBAN iban, List<AG_ROOT_Cont> conturi)
        {
            foreach (AG_ROOT_Cont c in conturi)
            {
                if (c.IBAN.Equals(iban))
                    return conturi.IndexOf(c);
            }

            return -1;


        }

        public List<AG_ROOT_Cont> TransferBaniIntreDouaConturi(Suma sum, AG_ROOT_Cont sursa, AG_ROOT_Cont dest)
        {
            //va returna conturile modificate
            if (sursa.Sold.getSuma - sum.getSuma >= 0)
            {
                if(sum.getSuma == 0)
                {
                    throw new ArgumentException("");
                }
                else
                {
                    Tranzactie tranzactie = new Tranzactie(new ID(1), dest.IBAN, TipTranzactie.Transfer);
                    //ia banii din contul celui care transfera
                    tranzactie.SetSumaTranzactionata(sum);
                    sursa.sold.getSuma -= tranzactie.Suma.getSuma;
                    sursa.IstoricTranzactii.AdaugaTranzactie(tranzactie);

                    //depune in contul altuia, update contul impactat!!
                     dest.sold.getSuma += tranzactie.Suma.getSuma;
                     Tranzactie tranzactie2 = new Tranzactie(new ID(1), sursa.iban, TipTranzactie.Transfer);
                     tranzactie2.SetSumaTranzactionata(sum);
                     dest.IstoricTranzactii.AdaugaTranzactie(tranzactie2);
                    //Console.WriteLine("Clientul: " + this.DateClient.Nume + " a depus " + sum.getSuma + " lei in contul lui " + destinatar.DateClient.Nume);
                    List<AG_ROOT_Cont> conturi = new List<AG_ROOT_Cont>();
                    conturi.Add(sursa);
                    conturi.Add(dest);
                    return conturi; //returneaza cele doua conturi cu informatiile updatate
                }
                    
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }
    }
}
