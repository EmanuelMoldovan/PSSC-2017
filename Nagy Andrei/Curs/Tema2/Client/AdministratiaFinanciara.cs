using Model.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Client
{
    public class AdministratiaFinanciara
    {
        public ContractCumparare Contract { get; private set; }
        public AdministratiaFinanciara(ContractCumparare contract)
        {
            Contract = contract;
        }

        public void MasinaCumparata()
        {
            Console.WriteLine("Masina a fost cumparata de catre client.");
        }
    }
}
