using System;
using System.Diagnostics.Contracts;

namespace Models.Generic
{
    public class PlainText
    {
        #region Private Fields
        private string _text;
        #endregion

        #region Public Properties
        public string Text
        {
            get
            {
                return _text;
            }
        }
        #endregion

        #region Constructors
        public PlainText(string text)
        {
            Contract.Requires(text != null, "Text cannot be null!");
            if (text == null) { throw new Exception("Text cannot be null!"); }

            Contract.Requires(!string.IsNullOrEmpty(text), "Text cannot be empty!");
            if (string.IsNullOrEmpty(text)) { throw new Exception("Text cannot be empty!"); }
            
            //Contract.Requires<ArgumentNullException>(text != null, "Text cannot be null!");
            //Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(text), "Text cannot be empty!");

            _text = text;
        }
        #endregion

        #region Public Overridden Methods
        public override string ToString()
        {
            return _text;
        }

        public override bool Equals(object obj)
        {
            var text = (PlainText)obj;
            return _text.Equals(text.Text);
        }

        public override int GetHashCode()
        {
            return _text.GetHashCode();
        }
        #endregion
    }
}