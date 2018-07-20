namespace Estudiantes.Domain.Entity{
    public class EstudiantePregrado: Estudiante{
        public override decimal calculateScholarship(){
            return 10;
        }
    }
}