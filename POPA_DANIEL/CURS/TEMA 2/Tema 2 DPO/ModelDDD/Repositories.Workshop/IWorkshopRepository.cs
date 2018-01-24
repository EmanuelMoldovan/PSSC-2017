using System;
namespace Repositories.Workshop
{
    interface IWorkshopRepository
    {
        void ActualizeazaWorkshop(Modele.Workshop.Workshop workshop);
        void AdaugaWorkshop(Modele.Workshop.Workshop workshop);
        Modele.Workshop.Workshop GasesteWorkshopDupaNume(string nume);

    }
}
