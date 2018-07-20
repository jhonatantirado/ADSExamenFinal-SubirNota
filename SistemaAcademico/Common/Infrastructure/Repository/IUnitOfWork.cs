
namespace Common.Infrastructure.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Locations.Domain.Repository;
    using Estudiantes.Domain.Repository;

    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        ILocationsRepository Locations { get;}
        IEstudiantesRepository Estudiantes { get;}
        
    }
}
