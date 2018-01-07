using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Etaj
{
    public class CamereEtaj
    {
        private List<Camera> _camere;
        public ReadOnlyCollection<Camera> Valori { get { return _camere.AsReadOnly(); } }

        internal CamereEtaj()
        {
            _camere = new List<Camera>();
        }

        internal CamereEtaj(List<Camera> camere){
            Contract.Requires(camere != null, "lista de camere");
            _camere = camere;
        }

        internal void AdaugaCamera(Camera camera){
            Contract.Requires(camera != null, "camera");
            _camere.Add(camera);
        }

        #region override object
        public override string ToString()
        {
            return _camere.Aggregate(new StringBuilder(), (builder, curs) => {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(curs);
                return builder;
            }).ToString();

        }

        public override bool Equals(object obj)
        {
            var cursuri = (CamereEtaj)obj;

            if (cursuri != null && cursuri._camere.Count == _camere.Count)
            {
                return _camere.Select((curs, idx) => new {Curs1 = curs, Curs2 = cursuri._camere[idx]})
                    .Aggregate(true, (equal, pair)=> equal && pair.Curs1.Equals(pair.Curs2));

            }
            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        #endregion
    }
}
