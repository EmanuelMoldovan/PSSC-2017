using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;


namespace Modele.Activitate
{
    public class Taberist
    {
        public IdTaberist Id { get;  set; }
        private TextNume nume { get; set; }
        public Puncte puncte { get;  set; } //value object

        public string sendFeedback()
        {
            Console.WriteLine("Feedback taberist:");
            string f = Console.ReadLine();
            return f;
        }
        public override string ToString()
        {
            return nume.ToString();
        }

        public override int GetHashCode()
        {
            return nume.GetHashCode();
        }
    }

   
}
