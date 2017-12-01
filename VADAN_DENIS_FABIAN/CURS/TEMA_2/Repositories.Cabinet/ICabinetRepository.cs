using System;

namespace Repositories.Cabinet
{
    interface ICabinetRepository
    {
        void ActualizeazaCabinet(Module.Cabinet.Cabinet cabinet);
        void AdaugaCabinet(Modele.Cabinbet.Cabinet cabinet);
        Modele.Disciplina.Disciplina GasesteDiscipilnaDupaNume(string nume);
    }
}
