using Common.Application;
using SistemaAcademico.Common;

namespace Estudiantes.Domain.Entity{
    public abstract class Estudiante
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentCode { get; set; }
        public string StudentType { get; set; }
        public decimal Scholarship { get; set; }
        public bool IsActive { get; set; }

        public Estudiante(){

        }
        public bool hasIdentity(){
            return !string.IsNullOrWhiteSpace(this.StudentCode);
        }

        public bool hasFullName(){
            return !string.IsNullOrWhiteSpace(this.FirstName) && !string.IsNullOrWhiteSpace(this.LastName);
        }

        public void activarEstudiante(){
            if (!this.IsActive) this.IsActive=true;
        }

        public void desactivarEstudiante(){
            if (this.IsActive) this.IsActive=false;
        }

        public abstract decimal calculateScholarship();

        private Notification validateForSave(){
            Notification notification = new Notification();
            if (!this.hasIdentity()){
                notification.addError("The student doesn´t have a student code");
            }
            if (!this.hasFullName()){
                notification.addError("The student doesn´t have a valid full name");
            }
            return notification;
        }
    }
}