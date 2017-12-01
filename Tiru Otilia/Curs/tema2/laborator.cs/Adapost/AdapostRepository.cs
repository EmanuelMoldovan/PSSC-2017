using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapostRepository
{
    class AdapostRepository
    {
        static void Main(string[] args)
        {
            
        private static List<Adapost.Adapost> ListaAnimale = new List<Adapost.Adapost>();

        public void AdaugaAdapost(Adapost.Adapost Adapost)
        {
            ListaAnimale.Add(Adapost);
        }

        public void StergeAdapost(Adapost.Adapost Adapost)
        {
            ListaAnimale.Remove(Adapost);
        }

        public override string ToString()
        {
            string sir ="";
            if (ListaAnimale.Count>0)
            {
                foreach (Adapost.Adapost d in ListaAnimale)
                {
                    sir += d.ToString();
                }
            }
            else
            {
                sir = "Nu exista nici o Adapost \n";
            }
            return sir;


        }
    }
}
