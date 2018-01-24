using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Entities;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Services
{
    public class AdaugareScrisoare
    {
        public static void adaugare_colet()
        {
            StoreScrisori.listaScrisori.Add(new Scrisoare("Maria Popescu", "Ion Popescu", "12.03.2017", false));
        }

    }
}
