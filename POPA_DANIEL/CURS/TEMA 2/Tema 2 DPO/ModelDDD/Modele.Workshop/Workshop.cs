using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Modele.Workshop
{
    public class Workshop
    {
        public PlainText Nume { get; internal set; }
        public Punctaj Clasament { get; internal set; }

        private List<Firma> _firmeInscrise;
        public ReadOnlyCollection<Firma> FirmeInscrise { get { return _firmeInscrise.AsReadOnly(); } }

        public StareWorkshop Stare { get; internal set; }

        public Laboratoare Laboratoare { get; internal set; }

        public Traininguri Traininguri { get; internal set; }

        internal Workshop(PlainText nume, Punctaj clasament)
        {
            Contract.Requires(nume != null, "nume");
            Contract.Requires(clasament != null, "clasament");

            Nume = nume;
            Clasament = clasament;
            _firmeInscrise = new List<Firma>();
            Stare = StareWorkshop.Inscrieri;
            Laboratoare = new Laboratoare();
            Traininguri = new Traininguri();
        }

        internal Workshop(PlainText nume, Punctaj clasament, List <Firma> firmeInscrise):this(nume, clasament)
        {
            Contract.Requires(firmeInscrise != null, "lista de firme inscrise");
            _firmeInscrise = firmeInscrise;
        }

        #region operatii
        public void InscrieFirma(Firma firma)
        {
            Contract.Requires(firma != null, "firma");
            Contract.Requires(Stare == StareWorkshop.Inscrieri, "nu ne aflam in perioada in care se fac inscrieri");

            var gasit = _firmeInscrise.FirstOrDefault(f => f.Equals(firma));
            if (gasit == null)
            {
                _firmeInscrise.Add(firma);
            }
            else
            {
                throw new FirmaExistaExceptions();
            }
        }

        public void IncepeWorkshop()
        {
            Contract.Requires(Stare == StareWorkshop.Inscrieri, "nu ne aflam in perioada in care se fac inscrieri");
            Stare = StareWorkshop.InDesfasurare;
        }

        public void IncheieWorkshop()
        {
            Contract.Requires(Stare == StareWorkshop.InDesfasurare, "Workshopul nu a inceput");
            foreach (var firma in _firmeInscrise)
            {
                firma.CalculeazaPretTotal(Clasament);
            }
            Stare = StareWorkshop.Incheiata;
        }

        public void NoteazaActivitateFirma(IdParticipare idParticipareFirma, Pret pret)
        {
            Contract.Requires(idParticipareFirma != null);
            Contract.Requires(pret != null);
            Contract.Requires(Stare == StareWorkshop.InDesfasurare, "workshopul nu a inceput");

            var firma = _firmeInscrise.First(f => f.IdParticipare.Equals(idParticipareFirma));
            firma.PreturiActivitati.AdaugaPret(pret);
        }

        public void TrecePretPachet(Dictionary< IdParticipare, Pret> rezultatePachet)
        {
            Contract.Requires(rezultatePachet != null);
            Contract.Requires(Stare == StareWorkshop.InDesfasurare, "workshopul nu a inceput");
            foreach (var pair in rezultatePachet)
            {
                var firma = _firmeInscrise.First(f => f.IdParticipare.Equals(pair.Key));
                firma.PretPachet = pair.Value;
            }
        }

        public void IncarcaMaterialTraining(PlainText numeTraining, Uri continutTraining)
        {
            Contract.Requires(numeTraining != null, "numeTraining");
            Contract.Requires(continutTraining != null, "continutTraining");
            var training = Traininguri.Valori.FirstOrDefault(t => t.Nume.Equals(numeTraining));
            if(training == null)
            {
                //trainingul trebuie creat
                training = new Training(numeTraining);
                training.LinkContinut = continutTraining;
                Traininguri.AdaugaTraining(training);
            }
            else
            {
                // trainingul este deja existent
                training.ActualizareLinkContinut(continutTraining);
            }
        }

        public void IncarcaMaterialLaborator(PlainText numeLaborator, Uri continutLaborator)
        {
            Contract.Requires(numeLaborator != null, "numeLaborator");
            Contract.Requires(continutLaborator != null, "continutLaborator");
            var laborator = Laboratoare.Valori.FirstOrDefault(t => t.Nume.Equals(numeLaborator));
            if (laborator == null)
            {
                // laboraturul trebuie creat
                laborator = new Laborator(numeLaborator);
                laborator.LinkContinut = continutLaborator;
                Laboratoare.AdaugaLaborator(laborator);
            }
            else
            {
                // laboratorul este deja existent
                laborator.ActualizareLinkContinut(continutLaborator);
            }
        }
        #endregion

        #region override object
        public override string ToString()
        {
            return Nume.ToString();
        }

        public override bool Equals(object obj)
        {
            var workshop = (Workshop)obj;

            if (workshop != null)
            {
                return Nume.Equals(workshop.Nume);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Nume.GetHashCode();
        }

        #endregion
    }
}
