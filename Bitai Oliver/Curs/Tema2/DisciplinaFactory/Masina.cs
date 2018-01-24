using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masina
{
    public class Masina
    {
        public string Model;
        public int CapMotor;
        public int Hp;
        public string Culoare;
        public int Pret;

        internal Masina(string Model,int CapMotor,int Hp,string Culoare,int Pret)
        {
            this.Model = Model;
            this.CapMotor = CapMotor;
            this.Hp = Hp;
            this.Culoare = Culoare;
            this.Pret = Pret;
        }

        public override string ToString()
        {
            return "  Model: " + Model.ToString() + "\n" + "   Capacitate motor: "+ CapMotor.ToString() + "\n" + "   Putere: " + Hp.ToString()+"Hp" + "\n" + "   Culoare: " + Culoare.ToString() + "\n" + "   Pret: " + Pret.ToString()+"E" + "\n\n";
        }
    }
}
