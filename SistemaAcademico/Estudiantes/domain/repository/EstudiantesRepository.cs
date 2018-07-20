using System.Collections.Generic;
using Common.Infrastructure.Repository;
using Estudiantes.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Estudiantes.Domain.Repository{
    public class EstudiantesRepository : BaseRepository<Estudiante>, IEstudiantesRepository
    {
        public EstudiantesRepository(PracticaExamenContext dbContext) : base(dbContext)
        {
        }

        public void save(Estudiante location)
        {
            base.Update(location);
        }
        public void deactivate(long id){
            Estudiante location = base.GetById(id);
            location.IsActive = false;
            base.Update(location);

        }
        public void activate(long id){
            Estudiante location = base.GetById(id);
            location.IsActive = true;
            base.Update(location);
        }
        public Estudiante findByStudentCode (string studentCode){
            return base.Context.Set<Estudiante>().Where(x => x.StudentCode==studentCode && x.IsActive).FirstOrDefault();
        }
        public List<Estudiante> findByStudentType (string studentType){
            return base.Context.Set<Estudiante>().Where(x => x.StudentType==studentType && x.IsActive).ToList();
        }
    }
}