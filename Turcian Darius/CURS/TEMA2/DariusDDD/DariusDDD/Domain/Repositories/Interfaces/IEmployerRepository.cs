using System;
using DariusDDD.Domain.Models;

namespace DariusDDD.Domain.Repositories.Interfaces
{
    public interface IEmployerRepository
    {
        Employer LoadEmployerByGuid(Guid guid);
        void AddEmployer(Employer employer);
    }
}
