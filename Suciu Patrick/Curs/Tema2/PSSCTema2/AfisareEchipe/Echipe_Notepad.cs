using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;





namespace AfisareEchipe
{
   public class Echipe_Notepad
    {
        public  Echipe_Notepad()
        {
        }
        public void Afisare( List<Modele.Echipe.Echipa> lista_echipe)
        {
          

           
            StreamWriter sw = new StreamWriter(@"C:\Users\Patrick\Desktop\Echipe.txt", true);
            for (int i = 0; i < lista_echipe.Count(); i++)
            {
                String nume_echipa ="Echipa:" +lista_echipe.ElementAt(i).get_nume();
                
                String tara = "Tara:" + lista_echipe.ElementAt(i).get_tara().ToString();

                String an = "Anul infiintarii:" + lista_echipe.ElementAt(i).get_an_infiintare().ToString();
            
                String culori = "Culori:" + lista_echipe.ElementAt(i).get_culori().ToString();

                sw.WriteLine(nume_echipa);
                sw.WriteLine(tara);
                sw.WriteLine(an);
                sw.WriteLine(culori);
                sw.WriteLine("--------------");
          
              


            }
            sw.Close();

        }
    }
}
