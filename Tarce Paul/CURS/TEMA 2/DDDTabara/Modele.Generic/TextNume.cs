using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Modele.Generic
{
    public class TextNume
    {
        private string _text;
        public string Text { get { return _text; } }
        public TextNume(string text)
        {
            Contract.Requires<ArgumentNullException>(text != null, "text");

            _text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
