using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Workshop
{
    public class Traininguri
    {
        private List<Training> _traininguri;
        public ReadOnlyCollection<Training> Valori { get { return _traininguri.AsReadOnly(); } }

        internal Traininguri()
        {
            _traininguri = new List<Training>();
        }

        internal Traininguri(List<Training> trainguri)
        {
            Contract.Requires(trainguri != null, "Lista de traininguri");
            _traininguri = trainguri;
        }

        internal void AdaugaTraining(Training training)
        {
            Contract.Requires(training != null, "training");
            _traininguri.Add(training);
        }

        #region override object

        public override string ToString()
        {
            return _traininguri.Aggregate(new StringBuilder(), (builder, training) =>
             {
                 if (builder.Length > 0) builder.Append(", ");
                 builder.Append(training);
                 return builder;
             }).ToString();
        }

        public override bool Equals(object obj)
        {
            var traininguri = (Traininguri)obj;

            if (traininguri != null && traininguri._traininguri.Count == _traininguri.Count)
            {
                return _traininguri.Select((training, idx) => new { Training1 = training, Training2 = traininguri._traininguri[idx] }).Aggregate
                    (true, (equal, pair) => equal && pair.Training1.Equals(pair.Training2));
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