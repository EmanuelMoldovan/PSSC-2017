using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Pacienti;
using Model.Spital;
using Novacode;
using SharedData;

namespace Model.DocumentePacient
{
    public class Reteta
    {
        public DateSpital dateSpital;
        public int nrReteta;
        public string gratuit;
        public Pacient pacient;
        public string diagnostic;
        public string reteta;
        public Data data;

        public Reteta(DateSpital d, int nr, string gr,Pacient p, string dg, string r,Data dt)
        {
            dateSpital = d;
            nrReteta = nr;
            gratuit = gr;
            pacient = p;
            diagnostic = dg;
            reteta = r;
            data = dt;
         
        }

        public DocX InlocuiesteCuvinte()
        {
            //string template = @"D:\faculta\An4\SEM 1\PSSC\Teme\Tema2\doc generator\tema2final\AdeverintaMedicala.docx";
            string template = @"Reteta.docx";
            DocX letter = DocX.Load(template);

            // Perform the replace:
            letter.ReplaceText("%JUDEUL%", dateSpital.judet);
            letter.ReplaceText("%LOCALITATEA%", dateSpital.localitate);
            letter.ReplaceText("%UNITATEA SANITARA%", dateSpital.unitateSanitara);

            letter.ReplaceText("%GRATUIT%", gratuit);
           
            letter.ReplaceText("%NUME INTREG%", pacient.numePacient.toString());
            letter.ReplaceText("%SEX% ", pacient.sex);

            var varsta =pacient.CalculeazaVarsta().ToString();
            letter.ReplaceText("%VARSTA%", varsta);

            letter.ReplaceText("%JUDETUL%", pacient.adresa.judet);
            letter.ReplaceText("%LOCALITATEA%", pacient.adresa.localitate);
            letter.ReplaceText("%STRADA%", pacient.adresa.strada);
            letter.ReplaceText("%NUMAR STRADA%", pacient.adresa.nrStrada.ToString());

            letter.ReplaceText("%DIAGNOSTIC%", diagnostic);
            letter.ReplaceText("%NR RETETA%", nrReteta.ToString());
            letter.ReplaceText("%RETETA%", reteta);

            letter.ReplaceText("%DATA%", data.toString());

            return letter;
        }

        public void GenereazaReteta(string cnp)
        {            
            string template = @"Reteta.docx";
            string fileNameTemplate = @"Reteta-{0}-Data-{1}.docx";
            string outputFileName = string.Format(fileNameTemplate, cnp, DateTime.Now.ToString("MM-dd-yy"));

            DocX letter = DocX.Load(template);

            letter = InlocuiesteCuvinte();
            letter.SaveAs(outputFileName);

        }
    }
}
