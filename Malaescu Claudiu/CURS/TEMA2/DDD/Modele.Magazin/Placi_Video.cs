using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace Modele.Magazin
{
    public class Placi_Video
    {
        private List<Placa_Video> placa_video;

        internal Placi_Video()
        {
            placa_video = new List<Placa_Video>();
          
        }
        internal Placi_Video(List<Placa_Video> placi_video)
        {
            Contract.Requires(placi_video != null, "lista de placi");
            this.placa_video = placi_video;
        }
           internal void AdaugaPlaca(Placa_Video placa)
         {
             Contract.Requires(placa != null, "placa video");
             placa_video.Add(placa);
         }


    }
}
