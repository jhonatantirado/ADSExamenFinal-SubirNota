namespace Estudiantes.Domain.Entity{
    public class EstudianteDoctorado: Estudiante{
        public override decimal calculateScholarship(){
            return 100;
        }
    }
}