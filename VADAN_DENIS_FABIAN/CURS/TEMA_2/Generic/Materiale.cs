using Generic.Exceptions.MaterialeDentareInsuficienteException;
using Modele.Generic.Exceptions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Modele.Generic
{
    public class Materiale
    {
        private List<Material> _materiale;
        public ReadOnlyCollection<Material> Valori { get { return _materiale.AsReadOnly(); } }

        public Materiale()
        {
            _materiale = new List<Material>();
        }
        
        internal Materiale(List<Material> materiale)
        {
            Contract.Requires(materiale != null, "lista de materiale");
            _materiale = materiale;
        }

        public Material PretTotal
        {
            get
            {
                if (_materiale.Count < 1)
                {
                    throw new MaterialeDentareInsuficienteException();
                }

                return new Material(_materiale.Select(n => n.Pret).Sum());
            }
        }

        internal void AdaugaNota(Material material)
        {
            Contract.Requires(material != null, "material");
            _materiale.Add(material);
        }

        #region override object
        public override string ToString()
        {
            return _materiale.Aggregate(new StringBuilder(), (builder, material) => {
                if (builder.Length > 0) builder.Append(", ");
                builder.Append(material);
                return builder;
            }).ToString();

        }

        public override bool Equals(object obj)
        {
            var materiale = (Materiale)obj;

            if (materiale != null && materiale._materiale.Count == _materiale.Count)
            {
                return _materiale.Select((material, idx) => new { Material1 = material, Material2 = materiale._materiale[idx] })
                    .Aggregate(true, (equal, pair) => equal && pair.Material1.Equals(pair.Material2));

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
