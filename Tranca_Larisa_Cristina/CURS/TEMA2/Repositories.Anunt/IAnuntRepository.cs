using System;
namespace Repositories.Anunt
{
    interface IAnuntRepository
    {
        void ActualizeazaAnunt(Modele.Anunt.Anunt anunt);
        void AdaugaAnunt(Modele.Anunt.Anunt anunt);
        Modele.Anunt.Anunt GasesteAnuntulDupaDescriere(string nume);
    }
}
