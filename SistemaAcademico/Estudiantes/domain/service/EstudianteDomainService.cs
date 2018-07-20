using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudiantes.Domain.Service
{
    using Estudiantes.Domain.Entity;
    using Common.Application;

    public class EstudianteDomainService
    {

        public decimal calculateScholarship(Estudiante estudiante) => estudiante.calculateScholarship();

    }
}
