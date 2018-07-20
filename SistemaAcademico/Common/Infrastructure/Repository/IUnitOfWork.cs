using System;
using Locations.Domain.Repository;
using Estudiantes.Domain.Repository;

namespace Common.Infrastructure.Repository
{


    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        ILocationsRepository Locations { get;}
        IEstudiantesRepository Estudiantes { get;}
        
    }
}
