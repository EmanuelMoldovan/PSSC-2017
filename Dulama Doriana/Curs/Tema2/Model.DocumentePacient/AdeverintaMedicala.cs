using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedData;
using Novacode;
using Model.Pacienti;
using Model.Spital;

namespace Model.DocumentePacient
{
    public class AdeverintaMedicala
    {
        public DateSpital dateSpital;
        public int nrFisa;
        public Pacient pacient;
        public string afectiune;
        public string recomandare;
        public string servire;
        public Data data;

        public AdeverintaMedicala()
        {
            dateSpital = new DateSpital("","","");
            nrFisa = 0;
            pacient = new Pacient();
            afectiune = "";
            recomandare = "";
            servire = "";
            data = new Data(0,0,0);
        }

        public AdeverintaMedicala(DateSpital d, int nr, Pacient p, string a, string r, string s, Data d2)
        {
            dateSpital = d;
            nrFisa = nr;
            pacient = p;
            afectiune = a;
            recomandare = r;
            servire = s;
            data = d2;
        }

        public DocX InlocuiesteCuvinte()
        {
            
            string template = @"AdeverintaMedicala.docx";
            DocX letter = DocX.Load(template);

            // Perform the replace:
            letter.ReplaceText("%JUDEUL%", dateSpital.judet);
            letter.ReplaceText("%LOCALITATEA%", dateSpital.localitate);
            letter.ReplaceText("%UNITATEA SANITARA%", dateSpital.unitateSanitara);
            letter.ReplaceText("%CARNET DE SANATATE%", nrFisa.ToString());
            letter.ReplaceText("%NUME INTREG%", pacient.numePacient.toString());
            letter.ReplaceText("%SEX% ", pacient.sex);
            letter.ReplaceText("%ANUL%", pacient.dataNastere.an.ToString());
            letter.ReplaceText("%LUNA%", pacient.dataNastere.luna.ToString());
            letter.ReplaceText("%ZIUA%", pacient.dataNastere.zi.ToString());
            letter.ReplaceText("%JUDETUL%", pacient.adresa.judet);
            letter.ReplaceText("%LOCALITATEA%", pacient.adresa.localitate);
            letter.ReplaceText("%STRADA%", pacient.adresa.strada);
            letter.ReplaceText("%NUMAR STRADA%", pacient.adresa.nrStrada.ToString());
            letter.ReplaceText("%OCUPATIA%", pacient.ocupatie);
            letter.ReplaceText("%LOCUL DE MUNCA%", pacient.locMunca);
            letter.ReplaceText("%BOALA% ", afectiune);
            letter.ReplaceText("%RECOMANDARE%", recomandare);
            letter.ReplaceText("%SERIVRE%", servire);
            letter.ReplaceText("%AN ELIBERARE%", data.an.ToString());
            letter.ReplaceText("%LUNA ELIBERARE%", data.luna.ToString());
            letter.ReplaceText("%ZI ELIBERARE%", data.zi.ToString());

            return letter;
        }
      
        public void GenereazaAdeverintaMedicala(string cnp)
        {          
            string template = @"AdeverintaMedicala.docx";
            
            string fileNameTemplate = @"Adeverinta-{0}-Data-{1}.docx";

            string outputFileName = string.Format(fileNameTemplate, cnp, DateTime.Now.ToString("MM-dd-yy"));

            DocX letter = DocX.Load(template);

            // Perform the replace:
            letter = InlocuiesteCuvinte();

            // Save as New filename:
            letter.SaveAs(outputFileName);

            // Open in word:
            //Process.Start("WINWORD.EXE", "\"" + outputFileName + "\"");
        }

    }
}
