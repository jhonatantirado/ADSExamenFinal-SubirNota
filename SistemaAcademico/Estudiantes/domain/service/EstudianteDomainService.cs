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

        public decimal calculateScholarship(Estudiante estudiante){
            return estudiante.calculateScholarship();
        }

        public List<Estudiante> getByStudentType(string studentType){
            return null;

        }



    }
}
