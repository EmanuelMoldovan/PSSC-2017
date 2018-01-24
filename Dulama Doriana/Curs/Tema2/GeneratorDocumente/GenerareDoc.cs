using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DocumentePacient;
using Model.Pacienti;
using Novacode;
using SharedData;
using Model.Spital;
using GeneratorPDF;
using Servicii.Pacient;

namespace GeneratorDocumente
{
    public class GenerareDoc
    {

        public void AlegeTipulDocumentului(string tipDocument,string cnp)
        {
            //date spital
            var judetSpital = "judetSpital";
            var localitateSpital = "localitateSpital";
            var unitateSanitara = "unitateSanitara";
            DateSpital dateSpital = new DateSpital(judetSpital, localitateSpital, unitateSanitara);
            var nrFisa = 234;

            DateTime azi = DateTime.Now;
            Data dataEiberare = new Data(azi.Day, azi.Month, azi.Year);

            //initializare
            Pacient pacient = new Pacient();

            var cauta = new CautaPacient();
            var gasit = cauta.Cauta(cnp);

            if (gasit == 1)
                // pacientAdeverinta = PacientFactory.Instance.creeazaPacient(cnp, numePacient, sexPacient, dataNastere, adresa, ocupatie, locMunca);
                pacient = cauta.PacientGasit(cnp);

            switch (tipDocument)
            {
                case "adeverinta medicala":

                    //adeverinta
                    
                    var afectiune = "pneumonie";
                    var recomandare = "Se recomanda perioada de o saptamana repaus acasa";
                    var serive = "insanatosire";
                   
                    AdeverintaMedicala adeverinta = new AdeverintaMedicala(dateSpital, nrFisa, pacient, afectiune, recomandare, serive, dataEiberare);

                    //adaugam pt istoric
                    pacient.afectiuneRecomandare.Add(afectiune, recomandare);
                    //adaugam in fisa istoric existenta pentru pacient
                   
                    if (pacient.istoricExistent == 0)
                    {
                        pacient.istoricExistent = 1;

                    }

                    adeverinta.GenereazaAdeverintaMedicala(cnp);
                    break;


                case "reteta":
                    //hardcoded
                    var nrReteta = 1;
                    var gratuit = "DA";
                    var diagnostic = "raceala";
                    var reteta = "Nurofen Raceala si Gripa - 3ori/zi" + "\n Trachisan 1/zi";

                    Reteta retetaFisa = new Reteta(dateSpital, nrReteta, gratuit, pacient, diagnostic, reteta,dataEiberare);
                    retetaFisa.GenereazaReteta(cnp);

                    break;
            }
        }

    }
}
