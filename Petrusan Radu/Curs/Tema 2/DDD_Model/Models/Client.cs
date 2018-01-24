using Models.Enums;

namespace Models
{
    public class Client : Persoana
    {
        public TipClient TipClient { get; private set; }

        public Client(Persoana persoana, TipClient tipClient) : base(persoana.Nume, persoana.Prenume, persoana.CNP)
        {
            TipClient = tipClient;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + TipClient;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}