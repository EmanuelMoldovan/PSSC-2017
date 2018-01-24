using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorPDF
{
    public class DeschidePDF
    {
        public DeschidePDF(string path)
        {
            Process.Start(path);
        }
    }
}
