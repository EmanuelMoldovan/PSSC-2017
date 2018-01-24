using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSC
{
   public  class RefreshFields
    {
        TextBox nume;

        public RefreshFields(TextBox nume)
        {
            this.nume = nume;
        }

        public TextBox Nume { get => nume; set => nume = value; }
        public void Refresh()
        {
            Nume.Text = String.Empty;
        }
    }
}
