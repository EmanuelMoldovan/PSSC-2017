using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Entities;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Services
{
    public class AdaugareColet
    {
        public static void adaugare_colet()
        {
            StoreColete.listColete.Add(new Colet("Ion Popescu", "Maria Popescu", "10.03.2017", "01", false, "0.5 kg"));
        }

    }
}
