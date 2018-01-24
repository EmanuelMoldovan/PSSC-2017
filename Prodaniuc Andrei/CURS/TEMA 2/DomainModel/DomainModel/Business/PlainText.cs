using DomainModel.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Business
{
    public class PlainText
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            private set { }
        }

        public PlainText(string text)
        {
            Contract.Requires<InvalidTextException>(text != null && !string.IsNullOrEmpty(text) && !string.IsNullOrWhiteSpace(text));
            _text = text;
        }

        public override string ToString()
        {
            return _text;
        }

        public override bool Equals(object obj)
        {
            var plainText = (PlainText)obj;
            return Text.Equals(plainText.Text);
        }

        public override int GetHashCode()
        {
            return _text.GetHashCode();
        }

    }
}
