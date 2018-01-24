using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfisareJucatori
{
   public class Jucatori_Notepad
    {
        public Jucatori_Notepad()
        {
        }
        public void Afisare(List<Modele.Jucatori.Jucatori> lista_jucatori)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Patrick\Desktop\Jucatori.txt", true);
            for (int i = 0; i < lista_jucatori.Count(); i++)
            {
                String nume = "Nume:" + lista_jucatori.ElementAt(i).get_nume();

                String varsta = "Varsta:" + lista_jucatori.ElementAt(i).get_varsta().ToString();

                String post = "Post:" + lista_jucatori.ElementAt(i).get_post().ToString();

                String nr_joc = "Nr_joc:" + lista_jucatori.ElementAt(i).get_nr_tricou().ToString();

                String echipa = "Echipa:" + lista_jucatori.ElementAt(i).get_echipa().ToString();
                sw.WriteLine(nume);
                sw.WriteLine(varsta);
                sw.WriteLine(post);
                sw.WriteLine(nr_joc);
                sw.WriteLine(echipa);
                sw.WriteLine("--------------");




            }
            sw.Close();
        }
    }
}
