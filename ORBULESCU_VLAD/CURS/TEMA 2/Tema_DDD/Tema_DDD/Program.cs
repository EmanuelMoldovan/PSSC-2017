using Modele.Banca;
using Repository.Banca;
using RepositoryClient.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicii.Banca;

namespace Tema_DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adaugam 3 bani - DEMO - TODO : Implement
            BancaRepository.AdaugaBanca(/*parametrii*/);
            BancaRepository.AdaugaBanca(/*parametrii*/);
            BancaRepository.AdaugaBanca(/*parametrii*/);

            //Adauga clienti
            ClientiRepository.AdaugaClient(/*parametrii*/);
            ClientiRepository.AdaugaClient(/*parametrii*/);
            ClientiRepository.AdaugaClient(/*parametrii*/);

            //Adauga clienti bancilor
            BancaService.AdaugaClient(BancaRepository.GetBanca(/*NrInreg*/));
            BancaService.AdaugaClient(BancaRepository.GetBanca(/*NrInreg*/));
            BancaService.AdaugaClient(BancaRepository.GetBanca(/*NrInreg*/));

            //TODO : Adauga conturi clientilor -> idem bancilor

            //Crediteaza un client
            BancaService.Crediteaza(ClientiRepository.GetClient(/*Cnp & Parametrii*/));

            //Exporta PDF & Baza de date
            GenerarePdf.Genereaza(/*parametrii - client, banca, cnp etc.*/);
            ExportareBazaDeDate.Exporta();
        }
    }
}
