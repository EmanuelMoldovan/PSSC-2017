using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using System.IO;

namespace Infrastructura.Raport
{
    public class GenereazaRaport
    {
        public void GenereazaRaportTranzactii(String continut)
        {
            string path=@"Raport.txt";

            if(!File.Exists(path))
                {

                    FileStream fs = File.Create(path);
                    fs.Dispose();
                     System.IO.File.WriteAllText (@path, continut);
                     fs.Close();

               }

                else if (File.Exists(path))
                {
                    FileStream fs = File.Open(path, FileMode.Open);
                    System.IO.File.WriteAllText (@path, continut);
                    fs.Close();
                }
            
        }
    }
}
