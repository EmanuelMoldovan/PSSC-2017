using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedData;

namespace Model.Pacienti
{
    public class PacientFactory
    {
        public static readonly PacientFactory Instance = new PacientFactory();

        public Pacient creeazaPacient(string c,NumeIntreg numePacient, string sex,Data dataNastere,Adresa adresa, string ocupatie, string locMunca)
        {
            var pacient = new Pacient(c,numePacient, sex, dataNastere, adresa, ocupatie, locMunca);
            Pacient.listaPacienti.Add(pacient);
            return pacient;
        }
    }
}
