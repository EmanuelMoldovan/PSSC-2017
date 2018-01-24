using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using System.Diagnostics.Contracts;

namespace Modele.Cont
{
    public class Tranzactie
    {
        ID id;
        DateTime data;
        IBAN partenerTranzactie;
        Suma suma;
        TipTranzactie tip;

        public ID ID { get { return id; } }
        public DateTime DataTranzactie{ get { return data; } }
        public IBAN PartenerTranzactie { get { return partenerTranzactie; } }
        public Suma Suma { get { return suma; } }
        public TipTranzactie Tip { get { return tip; } }

        public Tranzactie(ID id, IBAN partenerTranzactie, TipTranzactie tip)
        {
            this.id = id;
            this.partenerTranzactie = partenerTranzactie;
            this.tip = tip;
            this.data = DateTime.Now;
            suma = new Suma(0.0); //se va seta apoi
        }

        public void SetSumaTranzactionata (Suma sum)
        {
            this.suma = sum;
        }


       
    }
}
