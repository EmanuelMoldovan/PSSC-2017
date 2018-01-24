using System;
namespace Repositories.Etaj
{
    interface IEtajRepository
    {
        void ActualizeazaEtaj(Modele.Etaj.Etaj etaj);
        void AdaugaEtaj(Modele.Etaj.Etaj etaj);
        Modele.Etaj.Etaj GasesteEtajulDupaNumar(string numar);
    }
}
