using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models.Entities;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Services
{
    public class EliberareColet
    {
        public static void eliberare_colet(string nume_destinatar, string numar_colet)
        {
            foreach (Colet colet in StoreColete.listColete)
            {
                if(colet.Destinatar.CompareTo(nume_destinatar) == 0 && colet.Numar_inregistrare.CompareTo(numar_colet) == 0)
                {
                    StoreColete.listColete.Remove(colet);
                }
            }

        }
    }
}
