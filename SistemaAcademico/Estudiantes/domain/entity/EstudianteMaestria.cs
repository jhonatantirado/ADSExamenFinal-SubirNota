namespace Estudiantes.Domain.Entity{
    public class EstudianteMaestria: Estudiante{
        public override decimal calculateScholarship(){
            return 50;
        }
    }
}