using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Magazin
{
    public class Carcase_Calculatoare
    {
        private List<Carcasa_Calculator> carcase;
        internal Carcase_Calculatoare()
         {
             carcase = new List<Carcasa_Calculator>();
         }
 
         internal Carcase_Calculatoare(List<Carcasa_Calculator> carcase)
         {
             Contract.Requires(carcase != null, "lista de carcase de calculatoare");
             this.carcase = carcase;
         }
 
         internal void AdaugaCarcase(Carcasa_Calculator carcasa)
         {
             Contract.Requires(carcasa != null, "carcase");
             carcase.Add(carcasa);
         }
    }
    
}
