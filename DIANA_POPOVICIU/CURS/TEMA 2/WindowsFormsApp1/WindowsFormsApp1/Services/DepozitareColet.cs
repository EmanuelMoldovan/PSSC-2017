using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Entities;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Services
{
    public class DepozitareColet
    {
        public static void depozitare_colet(string numar_colet)
        {
            foreach (Colet colet in StoreColete.listColete)
            {
                if (colet.Numar_inregistrare.CompareTo(numar_colet) == 0)
                {
                    colet.Depozitat = true;
                }
            }
        }
    }
}
