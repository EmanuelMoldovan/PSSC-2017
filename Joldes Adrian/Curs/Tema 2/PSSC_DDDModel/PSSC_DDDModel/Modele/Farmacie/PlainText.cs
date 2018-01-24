using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace PSSC_DDDModel.Modele.Farmacie
{
    class PlainText
    {
        private string text;

        public string Text
        {
            get { return text; }
            private set { }
        }

        public PlainText(string text)
        {
            Contract.Requires(text != null, "text");
            /*
            Contract.Requires<PSSC_DDDModel.Exceptions.ArgumentInvalidLengthException>(
                text.Length>=3 && text.Length<=50,
                "Denumirea medicamentului trebuie sa aibas intre 3 si 50 de caractere");
             * */
            this.text = text;
        }

        #region override objects

        public override string ToString()
        {
            return text;
        }

        public override bool Equals(object obj)
        {
            var plainText = (PlainText)obj;
            return text.Equals(plainText.Text);
        }

        public override int GetHashCode()
        {
            return text.GetHashCode();
        }

        #endregion
    }
}
