using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Pacienti;
using GeneratorPDF;
using GeneratorDocumente;
using Meniu;
using Novacode;
using SharedData;
using Model.DocumentePacient;
using Servicii.Pacient;
using Model.FisePacient;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //hardcoded patient 1
            var cnpPacient = "0123456789";
            var numePacient = new NumeIntreg("Ana", "David");
            var sex = "F ";
            var dataNastere = new Data(7, 3, 1995);
            var adresa = new Adresa("Timis", "Timisoara", "Timocului", 1);
            var ocupatie = "student";
            var locMunca = "Firma1";

            //hardcoded patient 2
            var cnpPacient2 = "1234567890";
            var numePacient2 = new NumeIntreg("Denis", "Iulian");
            var sex2 = "M ";
            var dataNastere2 = new Data(11, 10, 1995);
            var adresa2 = new Adresa("Timis", "Timisoara", "Marasti", 20);
            var ocupatie2 = "contabil";
            var locMunca2 = "Firma2";

            //creeaza pacient
            var pacient1 = PacientFactory.Instance.creeazaPacient(cnpPacient,numePacient,sex, dataNastere, adresa, ocupatie, locMunca);
            //Console.WriteLine(pacient1.toString());
         
            //creeaza pacient 2
            var pacient2 = PacientFactory.Instance.creeazaPacient(cnpPacient2, numePacient2, sex2, dataNastere2, adresa2, ocupatie2, locMunca2);
            //Console.WriteLine(pacient2.toString());

            //for every hardcoded patient, generate his pdf file with personal data
            string pathPDF1 = @"DatePacient-"+pacient1.cnp + ".pdf";
            string pathPDF2 = @"DatePacient-"+pacient2.cnp + ".pdf";
            var generatorFisaDate = new FisaDateIdentificare();
            generatorFisaDate.GenerareFisa(pacient1, pathPDF1);
            generatorFisaDate.GenerareFisa(pacient2, pathPDF2);


            //afisare lista pacienti
            //Console.WriteLine("TOTI DIN LISTA");
            //foreach(Pacient p in Pacient.listaPacienti)
            //{
            //    Console.WriteLine(p.cnp);
            //}

            //afisare cnp pacienti
            Console.WriteLine("cnp pacienti existenti");
            foreach (Pacient p in Pacient.listaPacienti)
            {
                Console.WriteLine(p.cnp);
            }

            //MENIU

            int optiune = 0;

            do
            {
                var meniu = new MeniuPrincipal();
                CautaPacient cautaPacient;
                int gasit = 0;
                string pathPDF="";
                string cnpCautat="";
                 
                Console.WriteLine("\nAlegeti o optiune: \n");
                optiune = Convert.ToInt16(Console.ReadLine());

                switch (optiune)
                {
                    case 0: break;
                    case 1: //adaugare pacient
                        var meniuAdaugare = new MeniuSecundar();
                        Pacient pacientNou = meniuAdaugare.MeniuAdaugarePacient();
                        Pacient.listaPacienti.Add(pacientNou);

                        pathPDF = @"DatePacient-"+pacientNou.cnp + ".pdf";
                        var generator = new FisaDateIdentificare();
                        generator.GenerareFisa(pacientNou, pathPDF);

                        break;

                    case 2: //vizualizare fisa date personale
                        var meniuDate = new MeniuSecundar();
                        var cnp = meniuDate.MeniuFisaPersonala();

                        cautaPacient = new CautaPacient();
                        gasit=cautaPacient.Cauta(cnp);

                        if (gasit == 1)
                        {
                           pathPDF = @"DatePacient-" + cnp + ".pdf";

                            var pdfDoc = new DeschidePDF(pathPDF);
                        }
                        else
                        {
                            Console.WriteLine("cnp-ul cautat nu este inregistrat");
                        }
                       
                        break;

                    case 3://vizualizare istoric
                        Console.WriteLine("Dati cnp-ul pacientului cautat:");
                         cnpCautat = Console.ReadLine();

                        pathPDF = @"Istoric" + cnpCautat + ".pdf";

                        cautaPacient = new CautaPacient();
                        gasit=cautaPacient.Cauta(cnpCautat);
                        if (gasit == 1)
                        {
                            var pacientGasit3 = cautaPacient.PacientGasit(cnpCautat);

                            if (pacientGasit3.istoricExistent == 1)
                            {
                                var docIstoric = new IstoricPacient();
                                docIstoric.GenerareFisa(pacientGasit3, pathPDF);
                                var pdfDoc3 = new DeschidePDF(pathPDF);
                            }
                            else
                                Console.WriteLine("pacientul nu are istoric");
                           
                        }


                        break;

                    case 4://generare docuemnt

                        Console.WriteLine("Dati cnp-ul pacientului cautat.");
                        cnpCautat = Console.ReadLine();

                        //cauta pacient
                         cautaPacient = new CautaPacient();
                        gasit= cautaPacient.Cauta(cnpCautat);
                        var pacientGasit=new Pacient();

                        if (gasit == 1)
                          pacientGasit = cautaPacient.PacientGasit(cnpCautat);

                        var meniu4 = new MeniuSecundar();
                        var doc4 = Convert.ToInt16(meniu4.MeniuGenerareDocumente());

                        switch (doc4)
                        {
                            case 1: //adeverinta medicala
                                
                                    var generareDoc = new GenerareDoc();
                                    generareDoc.AlegeTipulDocumentului("adeverinta medicala", cnpCautat);  
                                
                                    //se adauga in dictionar pentru a ramane in istoricul pacientului datele
                                   // pacientGasit.afectiuneRecomandare.Add()
                                    
                                break;

                            case 2: //reteta

                                var generareDocReteta = new GenerareDoc();
                                generareDocReteta.AlegeTipulDocumentului("reteta", cnpCautat);

                                break;
                        }
                        break;

                    
                }
            } while (optiune != 0);
            //Console.Read();
        }
    }
}
